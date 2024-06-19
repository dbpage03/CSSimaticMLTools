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
        public XElement ogConnFrom { get; }
        public XElement ogStaticMember { get; }
        public XElement nStep { get; set; }
        public XElement nConnTo { get; set; }
        public XElement nConnFrom { get; set; }
        public XElement nStaticMember { get; set; }

        public void SetNo(int num)
        {
            nStep.SetAttributeValue("Number",num);
            if (nConnTo != null) { nConnTo.Element(ns + "NodeTo").Element(ns + "StepRef").SetAttributeValue("Number", num); }
            if (nConnFrom != null) { nConnFrom.Element(ns + "NodeFrom").Element(ns + "StepRef").SetAttributeValue("Number", num); }
            foreach (XElement member in ogStaticMember.Descendants("{http://www.siemens.com/automation/Openness/SW/Interface/v5}" + "Member"))
            {
                if (member.Attribute("Name").Value == "SNO")
                {
                    member.SetAttributeValue("StartValue",num);
                }
            }
        }
        public XDocument ReplaceInDoc(XDocument xmlDoc)
        {
            foreach ( XElement element in xmlDoc.Descendants() )
            {
                if (element == ogStaticMember)  { element.ReplaceWith(nStaticMember); }
                else if (element == ogStep)     { element.ReplaceWith(nStep); }
                else if (element == ogConnTo)   { element.ReplaceWith(nConnTo); }
                else if (element == ogConnFrom) { element.ReplaceWith(nConnFrom); }
            }
            return xmlDoc;
        }
        public GRAPHStepConnect(string ns, XElement step, XElement connTo, XElement connFrom, XElement staticMember)
        {
            this.ns = ns;
            this.ogStep = step;
            this.ogConnTo = connTo;
            this.ogConnFrom = connFrom;
            this.ogStaticMember = staticMember;
            this.nStep = step;
            this.nConnTo = connTo;
            this.nConnFrom = connFrom;
            this.nStaticMember = staticMember;
        }
    }
}
