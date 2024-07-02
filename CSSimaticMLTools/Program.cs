using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace CSSimaticMLTools
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.NewApp == true)
            {
                Application.Run(new SmeltSequence());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
        public static Exception XSave(XDocument xmlDoc, string fpath)
        {
            try
            {
                xmlDoc.Save(fpath);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Save xml file.\r\n" +  ex.Message,"Failed to Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex;
            }
        }
        public static Tuple<string, string,string> GetInfo(string fname)
        {
            string type;
            string name;
            string number;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fname);
            //Get Type, Name, and Number for FB, FC, DB or OB
            XmlNode node = xmlDoc.SelectSingleNode("Document/SW.Blocks.FB");
            if (node != null)
            {
                type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                name = node["AttributeList"]["Name"].InnerText;
                number = "FB" + node["AttributeList"]["Number"].InnerText;
            }
            else
            {
                node = xmlDoc.SelectSingleNode("Document/SW.Blocks.FC");
                if (node != null)
                {
                    type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                    name = node["AttributeList"]["Name"].InnerText;
                    number = "FC" + node["AttributeList"]["Number"].InnerText;
                }
                else
                {
                    node = xmlDoc.SelectSingleNode("Document/SW.Blocks.InstanceDB");
                    if (node != null)
                    {
                        type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                        name = node["AttributeList"]["Name"].InnerText;
                        number = "DB" + node["AttributeList"]["Number"].InnerText;
                    }
                    else
                    {
                        node = xmlDoc.SelectSingleNode("Document/SW.Blocks.OB");
                        //OB Support is Limited
                        if (node != null)
                        {
                            type = node["AttributeList"]["ProgrammingLanguage"].InnerText;
                            name = node["AttributeList"]["Name"].InnerText;
                            number = "OB" + node["AttributeList"]["Number"].InnerText;
                        }
                        else
                        {
                            type = "Null";
                            name = "Null";
                            number = "Null";
                        }
                    }
                }
            }
                return Tuple.Create(type, name, number);
        }

        public static void StepNtoDescCtrl(string file)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(file);
            foreach (XElement element in xmlDoc.Descendants())
            {
                if (element.Name == ns + "Step")
                {
                    int stepNo = int.Parse(element.Attribute("Number").Value);
                    Console.Write(element.Name + "\t");
                    Console.WriteLine(element.Attribute("Number").Value);

                    foreach (XElement action in element.Elements(ns + "Actions"))
                    {
                        bool descAction = false;
                        int descNo = 0;
                        foreach (XElement token in action.Elements(ns + "Action").Descendants())
                        {
                            //Console.WriteLine(token.Attribute("Text").Value);
                            if (token.Attribute("Text").Value.Contains("DescriptorControl"))
                            {
                                descAction = true;
                                Console.Write("Desc ");

                            }
                            if (descAction && int.TryParse(token.Attribute("Text").Value, out descNo))
                            {
                                if (stepNo == 1)    {stepNo = 0;}
                                if (stepNo == 999)  {stepNo = 1;}
                                Console.WriteLine(token.Attribute("Text").Value);
                                token.Attribute("Text").Value = stepNo.ToString();
                                Console.WriteLine("New Desc: " + token.Attribute("Text").Value); break;
                            }
                        }
                    }

                }
            }
            if (XSave(xmlDoc, file) == null)
            {
                MessageBox.Show("Operation Complete", "Operation Complete");
            }
            
        }
        public static void SeqToDescTXT(string fpath)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            List<List<string>> descList = new List<List<string>>();
            List<List<string>> timeoutsList = new List<List<string>>();
            string listName = Interaction.InputBox("Enter the Base Name for the Text Lists.\nEx. BP_FillBH", "Enter List Name");
            foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
                //Print Step Name
                Console.WriteLine(step.Attribute("Name"));
                int descNo = 0;
                bool descStep = false;
                string stepTitle = "";
                //Find Text to put into Text List
                foreach (XElement multiLanguageText in step.Element(ns + "Actions").Descendants(ns + "MultiLanguageText")) {
                    //Print Step Description
                    Console.WriteLine(multiLanguageText.Value);
                    stepTitle = multiLanguageText.Value;
                }
                //Loop through Actions
                foreach (XElement action in step.Descendants(ns + "Action"))
                {
                    //Print Action Name
                    //Console.WriteLine(action.Name);
                    bool descAction = false;
                    
                    //Loop through Tokens
                    foreach (XElement token in action.Descendants(ns + "Token"))
                    {
                        //Descriptor Action?
                        if (token.Attribute("Text").Value.Contains("DescriptorControl"))
                        {
                            descAction = true;
                            descStep = true;
                            Console.Write("Desc ");

                        }
                        //Descriptor Number?
                        if (descAction && int.TryParse(token.Attribute("Text").Value, out int i))
                        {
                            //Console.WriteLine(token.Attribute("Text").Value);
                            descNo = int.Parse(token.Attribute("Text").Value);
                            Console.WriteLine(descNo);
                        }
                    }
                }

                if (descStep) 
                {
                    //Description List
                    descList.Add(new List<string>() {
                        listName + "_Desc",
                        descNo.ToString(),
                        descNo.ToString(),
                        "0",
                        "0",
                        stepTitle,
                        stepTitle
                    });
                    //Timeout List
                    foreach (XElement access in step.Element(ns + "Supervisions").Descendants(ns + "Access"))
                    {
                        if (descNo != 0 && descNo != 1)
                        {
                            Console.WriteLine(access.Name);
                            stepTitle = "Failed to " + stepTitle;
                            timeoutsList.Add(new List<string>() {
                                listName + "_Timeouts",
                                descNo.ToString(),
                                descNo.ToString(),
                                "0",
                                "0",
                                stepTitle,
                                stepTitle
                            });
                            break;
                        }
                    }

                    
                }
            }

            //Initialize TXT File
            try
            {
                StreamWriter txtFile = new StreamWriter(path:fpath.Replace(".xml", ".txt"),append:false, encoding: Encoding.Unicode);
                txtFile.WriteLine(string.Join("\t",new List<string>{ "RESOURCELIST_LIST", "Lists", "List" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { "[LIST_NAME][2][1]", "[LIST_TYPE][3][1]", "[LIST_RESTYPE][4][1]" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { "Name", "Selection", "Resource type" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { listName + "_Desc", "Value/Range", "Text" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { listName + "_Timeouts", "Value/Range", "Text\n" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { "RESOURCELIST_TEXT", "Texts", "Text" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { "[DATA_LIST][13][1]", "[DATA_FROM][14][1]", "[DATA_TO][15][1]", "[DATA_DEFAULT][18][2]", "[DATA_TEXTID][65547][1]", "[DATA_TEXT_L1031][67567627][7]", "[DATA_TEXT_L1033][67698699][7]"}));
                txtFile.WriteLine(string.Join("\t", new List<string> { "List", "Range from", "Range to", "Standard", "Text ID:", "Text (DEU)", "Text (ENU)" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { listName + "_Timeouts", "0", "0", "0", "0", "Waiting for Command", "Waiting for Command" }));
                txtFile.WriteLine(string.Join("\t", new List<string> { listName + "_Timeouts", "1", "1", "0", "0", "Resetting Sequence", "Resetting Sequence" }));

                foreach (List<string> line in descList)
                {
                    txtFile.WriteLine(string.Join("\t", line));
                }
                foreach (List<string> line in timeoutsList)
                {
                    txtFile.WriteLine(string.Join("\t", line));
                }

                txtFile.Close();
                MessageBox.Show("Operation Complete", "Operation Complete");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Write Text File", "Failed to Write Text File",icon:MessageBoxIcon.Error,buttons:MessageBoxButtons.OK);
            }
            
        }
        public static void RewriteSteps(string fpath)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            foreach (XElement sequence in xmlDoc.Descendants(ns + "Sequence"))
            {
                string strSeqNo = Interaction.InputBox("Which sequence number would you like to rewrite the steps for?", "Select Sequence Number");
                List<GRAPHStepConnect> stepConnects = new List<GRAPHStepConnect>();
                //Don't Do Reset Sequence
                if (sequence.Element(ns + "Title").Element(ns + "MultiLanguageText").Value == "Reset") { continue; }
                
                foreach (XElement step in sequence.Descendants(ns + "Step")) 
                {
                    XElement connTo = null;
                    XElement connFrom = null;
                    XElement staticMember = null;
                    foreach (XElement conn in sequence.Descendants(ns + "Connection"))
                    {
                        if (conn.Element(ns + "NodeTo").Descendants(ns + "StepRef").Count() > 0)
                        {
                            if (conn.Element(ns + "NodeTo").Descendants(ns + "StepRef").First().Attribute("Number").Value == step.Attribute("Number").Value)
                            {
                                connTo = conn;
                            }
                        }
                        if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").Count() > 0) 
                        {
                            if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").First().Attribute("Number").Value == step.Attribute("Number").Value)
                            {
                                connFrom = conn;
                            }
                        }
                    }
                    foreach (XElement member in xmlDoc.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
                    {
                        if (member.Attribute("Name").Value == step.Attribute("Name").Value && member.Attribute("Datatype").Value == "G7_StepPlus_V6")
                        {
                            staticMember = member;
                            break;
                        }
                    }
                    stepConnects.Add(new GRAPHStepConnect(ns, step, connTo, connFrom, staticMember));
                }
                int i = 1000;
                foreach (GRAPHStepConnect connect in stepConnects)
                {
                    connect.SetNo(i);
                    connect.ReplaceInDoc(xmlDoc);
                    i++;

                }
            }
			if (XSave(xmlDoc, fpath) == null)
			{
				MessageBox.Show("Operation Complete", "Operation Complete");
			}
		}
        public static void InStepReplaceX(string fpath)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            int sSrc = 2661054;
            int tSrc = 2661054;
            List<List<int>> numList = new List<List<int>>() 
            {
                new List<int>(3) {651 , 695, 2661001},
                new List<int>(3) {653 , 694, 2661002},
                new List<int>(3) {655 , 693, 2661003},
                new List<int>(3) {657 , 692, 2661004},
                new List<int>(3) {659 , 691, 2661043},
                new List<int>(3) {661 , 690, 2661044},
                new List<int>(3) {663 , 689, 2661005},
                new List<int>(3) {665 , 688, 2661006},
                new List<int>(3) {667 , 687, 2661045},
                new List<int>(3) {669 , 686, 2661007},
                new List<int>(3) {671 , 685, 2661009},
                new List<int>(3) {673 , 684, 2661010},
                new List<int>(3) {675 , 683, 2661011},
                new List<int>(3) {677 , 682, 2661012}
            };
            foreach (List<int> iList in numList)
            {
                foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
                {
                    if (step.Attribute("Number").Value == iList[0].ToString() || step.Attribute("Number").Value == iList[1].ToString())
                    {
                        string tNum = "0";
                        Console.WriteLine("S_No:\t" + step.Attribute("Number").Value);
                        foreach (XElement token in step.Descendants(ns + "Token"))
                        {
                            token.SetAttributeValue("Text",token.Attribute("Text").Value.Replace(sSrc.ToString(),iList[2].ToString()));
                        }
                        foreach (XElement component in step.Descendants(ns +"Component"))
                        {
                            component.SetAttributeValue("Name",component.Attribute("Name").Value.Replace(tSrc.ToString(),iList[2].ToString()));
                        }
                        //Transition Time
                        foreach (XElement conn in xmlDoc.Descendants(ns + "Connection"))
                        {
                            if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").Count() > 0)
                            {
                                if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").First().Attribute("Number").Value == step.Attribute("Number").Value)
                                {
                                    tNum = conn.Element(ns + "NodeTo").Descendants().First().Attribute("Number").Value;
                                    Console.WriteLine("T_No:\t" + tNum);
                                    break;
                                }
                            }
                        }
                        foreach (XElement trans in xmlDoc.Descendants(ns + "Transition"))
                        {
                            if (trans.Attribute("Number").Value == tNum)
                            {
                                foreach (XElement component in trans.Descendants(ns + "Component"))
                                {
                                    component.SetAttributeValue("Name", component.Attribute("Name").Value.Replace(tSrc.ToString(), iList[2].ToString()));
                                }
                                break;
                            }
                        }
                    }
                }
            }
			if (XSave(xmlDoc, fpath) == null)
			{
				MessageBox.Show("Operation Complete", "Operation Complete");
			}
		}
        public static void SNameRDesc(string fpath,DataGridView grid)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            foreach (XElement step in xmlDoc.Descendants(ns + "Step")) 
            {
                 foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells["TableStep"].Value != null)
                    {
                        //Console.WriteLine("E\t" + row.Cells[0].Value.ToString());
                        if (row.Cells["TableStep"].Value.ToString().PadLeft(3, '0') == step.Attribute("Number").Value.PadLeft(3, '0'))
                        {
                            Console.WriteLine(step.Attribute("Name").Value);
                            string desc;
                            if (row.Cells["TableDesc"].Value != null)
                            {
                                desc = row.Cells["TableDesc"].Value.ToString();
                            }
                            else { desc = ""; }

                            if (step.Element(ns + "Actions").Descendants(ns + "MultiLanguageText").Count() > 0)
                            {
                                step.Element(ns + "Actions").Descendants(ns + "MultiLanguageText").First().Value = desc;
                            }
                            else
                            {
                                step.Element(ns + "Actions").AddFirst(new XElement(ns + "Title"));
                                step.Element(ns + "Actions").Element(ns + "Title").AddFirst(new XElement(ns + "MultiLanguageText", desc));
                                step.Element(ns + "Actions").Element(ns + "Title").Element(ns + "MultiLanguageText").SetAttributeValue("Lang", "en-US");
                            }
                            break;
                        }
                    }
                }
            }
			if (XSave(xmlDoc, fpath) == null)
			{
				MessageBox.Show("Operation Complete", "Operation Complete");
			}

		}
        public static void GetStepNames(string fpath, DataGridView grid,bool clear = false)
        {
            if (clear) { grid.Rows.Clear(); }
            
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
                string sNo = step.Attribute("Number").Value.PadLeft(3,'0');
                string sName = step.Attribute("Name").Value;
                string sDescNo = "";
                string sDesc = "";
                

                if (step.Element(ns + "Actions").Descendants(ns + "Title").Count() > 0)
                {
                    sDesc = step.Element(ns + "Actions").Descendants(ns + "MultiLanguageText").First().Value;
                }
                foreach (XElement action in step.Descendants(ns + "Action"))
                {
                    bool descAction = false;
                    //Loop through Tokens
                    foreach (XElement token in action.Descendants(ns + "Token"))
                    {
                        //Descriptor Action?
                        if (token.Attribute("Text").Value.Contains("DescriptorControl"))
                        {
                            descAction = true;
                        }
                        //Descriptor Number?
                        if (descAction && int.TryParse(token.Attribute("Text").Value, out int i))
                        {
                            //Console.WriteLine(token.Attribute("Text").Value);
                            sDescNo = token.Attribute("Text").Value;
                        }
                    }
                }
                if (clear)
                {
                    grid.Rows.Add(sNo, sName, sDescNo, sDesc);
                } else
                {
                    foreach ( DataGridViewRow row in grid.Rows)
                    {
                        if (row.Cells["TableStep"].Value.ToString() == sNo || row.Cells["TableName"].Value.ToString() == sName )
                        {
                            row.SetValues(sNo, sName, sDescNo, sDesc);
                            break;
                        }
                    }
                }
                
            }
        }
        public static int RenumberStep(string fpath,int sNo, int nNo)
        {
            string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
            XDocument xmlDoc = XDocument.Load(fpath);
            bool nNoValid = true;
            GRAPHStepConnect tempConn = null;
            GRAPHStepConnect stepConn = null;
            if (nNo < 0 || nNo > 9999) { return sNo; }
            foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
				XElement connTo = null;
                XElement connFrom = null;
                XElement staticMember = null;
                foreach (XElement conn in xmlDoc.Descendants(ns + "Connection"))
                {
                    if (conn.Element(ns + "NodeTo").Descendants(ns + "StepRef").Count() > 0)
                    {
                        if (conn.Element(ns + "NodeTo").Descendants(ns + "StepRef").First().Attribute("Number").Value == step.Attribute("Number").Value)
                        {
                            connTo = conn;
                        }
                    }
                    if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").Count() > 0)
                    {
                        if (conn.Element(ns + "NodeFrom").Descendants(ns + "StepRef").First().Attribute("Number").Value == step.Attribute("Number").Value)
                        {
                            connFrom = conn;
                        }
                    }
                }
                foreach (XElement member in xmlDoc.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
                {
                    if (member.Attribute("Name").Value == step.Attribute("Name").Value && member.Attribute("Datatype").Value == "G7_StepPlus_V6")
                    {
                        staticMember = member;
                        break;
                    }
                }
                tempConn = new GRAPHStepConnect(ns, step, connTo, connFrom, staticMember);
                if (tempConn.sNo == sNo)
                {
                    stepConn = new GRAPHStepConnect(ns, step, connTo, connFrom, staticMember);
                }
                if (tempConn.sNo == nNo) { nNoValid = false; }

            }
            if (nNoValid && stepConn != null)
            {
				//Console.Write(stepConn.ogStep.Element(ns + "Supervisions").Element(ns + "Supervision").ToString());
				foreach (XElement component in stepConn.ogStep.Descendants()) { Console.WriteLine(component.ToString()); }
				stepConn.SetNo(nNo);
				XSave(stepConn.ReplaceInDoc(xmlDoc), fpath);
				return nNo;
            } else { return sNo; }


            
        }
        public static void RenameStep(string fpath, int sNo, string name)
        {
			string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
			XDocument xmlDoc = XDocument.Load(fpath);
            XElement sChg = null;
            bool valid = true;
			foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
                if (step.Attribute("Number").Value == sNo.ToString())
                {
                    sChg = step;
                }
                if (step.Attribute("Name").Value == name)
                {
                    valid = false; break;
                }
            }
            if (valid && sChg != null && name != "")
            {
                bool memberSet = false;
				foreach (XElement member in xmlDoc.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
				{
					if (member.Attribute("Datatype").Value == "G7_StepPlus_V6")
					{
                        foreach (XElement subMem in member.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
                        {
                            if (subMem.Attribute("Datatype").Value == "Int")
                            {
                                if (subMem.Descendants().First().Value == sChg.Attribute("Number").Value)
                                {
                                    member.Attribute("Name").SetValue(name);
                                    memberSet = true;
                                }
                            }
                            break;
                        }
					}
				}
                if (memberSet) { sChg.Attribute("Name").SetValue(name); XSave(xmlDoc, fpath); }
                
            } else { MessageBox.Show("Failed to Change Step Name", "Operation Failed"); }

		}
        public static void RemoveDesc(string fpath, int sNo)
        {
			string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
			XDocument xmlDoc = XDocument.Load(fpath);
            foreach (XElement step in xmlDoc.Descendants(ns + "Step")) 
            {
                if (step.Attribute("Number").Value != sNo.ToString()) { continue; }
                foreach (XElement action in  step.Descendants(ns + "Action")) 
                {
					bool descAction = false;
                    foreach (XElement token in action.Descendants(ns + "Token"))
                    {
						if (token.Attribute("Text").Value.Contains("DescriptorControl"))
						{
							descAction = true;
                            break;
						}
					}
                    if (descAction)
                    {
                        action.Remove();
						XSave(xmlDoc, fpath);
                        break;
                    }
				}
            }
		}
        public static void FixValveSteps(string fpath)
        {
			string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
			XDocument xmlDoc = XDocument.Load(fpath);

            foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
                string valve = "";
				XElement sv = XElement.Parse(
					"<Supervision ProgrammingLanguage=\"LAD\" xmlns=\"http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5\">" +
						"<Title>" +
							"<MultiLanguageText Lang=\"en-US\">Step Timeout</MultiLanguageText>" +
						"</Title>" +
						"<FlgNet>" +
							"<Parts>" +
								"<Access Scope=\"LocalVariable\" UId=\"21\">" +
									"<Symbol>" +
										"<Component Name=\"WeeWoo\" />" +
										"<Component Name=\"Valve\" />" +
										"<Component Name=\"collectError\" />" +
									"</Symbol>" +
								"</Access>" +
								"<Part Name=\"Contact\" UId=\"22\" />" +
								"<Part Name=\"SvCoil\" UId=\"23\" />" +
							"</Parts>" +
							"<Wires>" +
								"<Wire UId=\"24\">" +
									"<Powerrail />" +
									"<NameCon UId=\"22\" Name=\"in\" />" +
								"</Wire>" +
								"<Wire UId=\"25\">" +
									"<IdentCon UId=\"21\" />" +
									"<NameCon UId=\"22\" Name=\"operand\" />" +
								"</Wire>" +
								"<Wire UId=\"26\">" +
									"<NameCon UId=\"22\" Name=\"out\" />" +
									"<NameCon UId=\"23\" Name=\"in\" />" +
								"</Wire>" +
							"</Wires>" +
						"</FlgNet>" +
					"</Supervision>");
				foreach (XElement action in step.Descendants(ns + "Action"))
                {
                    if (action.HasAttributes && action.Attribute("Qualifier").Value == "D")
                    {
                        bool liAutAction = false;
                        foreach (XElement token in action.Descendants()) 
                        {
                            if (token.Attribute("Text").Value.Contains("LiAut"))
                            {
                                liAutAction = true;

                            }
                            if (liAutAction && token.Attribute("Text").Value.Contains("t#"))
                            {
                                token.SetAttributeValue("Text","t#2s");
                                action.SetAttributeValue("Qualifier", "L");
                            }
                        }
                    }
                    foreach (XElement token in action.Descendants())
                    {
                        if (token.Attribute("Text").Value.EndsWith(".LiAutOpen") || (token.Attribute("Text").Value.EndsWith(".LiAutClose")))
                        {
                            valve = token.Attribute("Text").Value.Replace(".LiAutOpen", "").Replace(".LiAutClose", "").Substring(1);
                        }
                    }
				}
                if (valve != "")
                {
                    foreach (XElement component in sv.Descendants()) { Console.WriteLine(component.ToString()); }
                    sv.Descendants(ns + "Component").First().Attribute("Name").SetValue(valve);
                    step.Element(ns + "Supervisions").RemoveAll();
                    step.Element(ns + "Supervisions").Add(sv);
                }
				

			}
			if (XSave(xmlDoc, fpath) == null)
			{
				MessageBox.Show("Operation Complete", "Operation Complete");
			}
		}
        public static void AddStepTimeouts(string fpath)
        {
			string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
			XDocument xmlDoc = XDocument.Load(fpath);
            XElement stR;
            XElement stV;

			string prefix = Interaction.InputBox("Enter the path of StepTimeout.\nEx. #V1411_Data.HMI_StepTimeout, #StepTimeout", "Enter StepTimeout Path","#");
            if (prefix != "")
            {
                stR = XElement.Parse("<Action Event=\"S1\" Qualifier=\"R\" xmlns=\"http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5\"><Token Text=\"" + prefix + "\" /><Token Text=\"&#xA;\" /></Action>");
                stV = XElement.Parse("<Action Event=\"V1\" Qualifier=\"S\" xmlns=\"http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5\"><Token Text=\"" + prefix + "\" /><Token Text=\"&#xA;\" /></Action>");
            } else { return; }
			foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
            {
                foreach (XElement action in  step.Descendants(ns + "Action")) 
                {
                    foreach (XElement token in action.Descendants(ns + "Token"))
                    {
                        if (token.Attribute("Text").Value.Contains("StepTimeout"))
                        {
                            action.Remove();
                            break;
                        }
                    }
                }
				foreach (XElement access in step.Element(ns + "Supervisions").Descendants(ns + "Access"))
                {
                    step.Element(ns + "Actions").LastNode.AddBeforeSelf(stR);
					step.Element(ns + "Actions").LastNode.AddBeforeSelf(stV);
                    break;
				}
					
			}
			if (XSave(xmlDoc, fpath) == null)
			{
				MessageBox.Show("Operation Complete", "Operation Complete");
			}
		}
        public static void EditDescNo(string fpath, int sNo, string nNo)
        {
			string ns = "{http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5}";
			XDocument xmlDoc = XDocument.Load(fpath);
            XElement XEdesc = XElement.Parse("<Action Event=\"S1\" Qualifier=\"N\" xmlns=\"http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5\"><Token Text=\"#DescriptorControl\" /><Token Text=\" \" /><Token Text=\":=\" /><Token Text=\"0\" /><Token Text=\"&#xA;\" /></Action>");


			if (nNo != "")
            {
                string prefix = Interaction.InputBox("Enter the path of DescriptorControl.\nEx. #V1411_Data.DescriptorControl, #DescriptorControl", "Enter DescriptorControl Path", Properties.Settings.Default.DescPath);
				Properties.Settings.Default.DescPath = prefix;
				Properties.Settings.Default.Save();
				XEdesc = XElement.Parse("<Action Event=\"S1\" Qualifier=\"N\" xmlns=\"http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5\"><Token Text=\"" + prefix + "\" /><Token Text=\" \" /><Token Text=\":=\" /><Token Text=\"" + nNo + "\" /><Token Text=\"&#xA;\" /></Action>");
			}
			foreach (XElement step in xmlDoc.Descendants(ns + "Step"))
			{
				if (step.Attribute("Number").Value != sNo.ToString()) { continue; }
                foreach (XElement action in step.Descendants(ns + "Action"))
                {
                    bool descAction = false;
                    foreach (XElement token in action.Descendants(ns + "Token"))
                    {
                        if (token.Attribute("Text").Value.Contains("DescriptorControl"))
                        {
                            descAction = true;
                            break;
                        }
                    }
                    if (descAction)
                    {
                        action.Remove();
                        break;
                    }
                }
                if (nNo != "")
                {
                    step.Element(ns + "Actions").LastNode.AddBeforeSelf(XEdesc);
                }
                XSave(xmlDoc, fpath);
			}
		}
    }
}
