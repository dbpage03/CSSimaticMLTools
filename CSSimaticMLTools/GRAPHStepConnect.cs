using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSSimaticMLTools
{
    internal class GRAPHStepConnect
    {
        public string ns { get; set; }
        public XElement ogStep { get; }
        public XElement ogConnTo { get; }
		public List<XElement> ogConnsTo { get; }
		public XElement ogConnFrom { get; }
        public XElement ogStaticMember { get; }
        public XElement nStep { get; set; }
        public XElement nConnTo { get; set; }
		public List<XElement> nConnsTo { get; }
		public XElement nConnFrom { get; set; }
        public XElement nStaticMember { get; set; }
        public int sNo { get; }

        public void SetNo(int num)
        {
            nStep.SetAttributeValue("Number",num);
            //nConnTo?.Element(ns + "NodeTo").Element(ns + "StepRef").SetAttributeValue("Number", num);
            foreach (XElement e in nConnsTo) 
            { 
                e?.Element(ns + "NodeTo").Element(ns + "StepRef").SetAttributeValue("Number", num);
			}
            nConnFrom?.Element(ns + "NodeFrom").Element(ns + "StepRef").SetAttributeValue("Number", num);
            foreach (XElement member in ogStaticMember.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
            {
                if (member.Attribute("Name").Value == "SNO")
                {
                    member.SetElementValue("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "StartValue", num);
                }
            }
        }
        public XDocument ReplaceInDoc(XDocument xmlDoc)
        {
            foreach ( XElement element in xmlDoc.Descendants() )
            {
                if (element == ogStaticMember) { element.ReplaceWith(nStaticMember); }
                else if (element == ogStep) { element.ReplaceWith(nStep); }
                //else if (element == ogConnTo) { element.ReplaceWith(nConnTo); }
                else if (element == ogConnFrom) { element.ReplaceWith(nConnFrom); }
                else
                {
                    int i = 0;
                    foreach (XElement e in ogConnsTo)
                    {
                        if (element == e)
                        {
                            e.ReplaceWith(nConnsTo[i]);
                        }
                        i++;
                    }
                }
            }
            return xmlDoc;
        }
        public GRAPHStepConnect(string ns, XElement step, List<XElement> connsTo, XElement connFrom, XElement staticMember)
        {
            this.ns = ns;
            this.ogStep = step;
            this.ogConnsTo = connsTo;
            this.ogConnFrom = connFrom;
            this.ogStaticMember = staticMember;
            this.nStep = step;
            this.nConnsTo = connsTo;
            this.nConnFrom = connFrom;
            this.nStaticMember = staticMember;
            this.sNo = int.Parse(step.Attribute("Number").Value);
        }
    }
}
