﻿namespace OopFactory.X12.Shared.Models.TypeSegment
{
    using OopFactory.X12.Shared.Enumerations;
    using OopFactory.X12.Shared.Extensions;

    /// <summary>
    /// Date/Time Reference
    /// </summary>
    public class TypedSegmentDTM : TypedSegment
    {
        public TypedSegmentDTM()
            : base("DTM")
        {
        }

        public DTPQualifier DTM01_DateTimeQualifier
        {
            get { return this.Segment.GetElement(1).ToEnumFromEDIFieldValue<DTPQualifier>(); }
            set { this.Segment.SetElement(1, value.EDIFieldValue()); }
        }

        public string DTM02_Date
        {
            get { return this.Segment.GetElement(2); }
            set { this.Segment.SetElement(2, value); }
        }

        public string DTM03_Time
        {
            get { return this.Segment.GetElement(3); }
            set { this.Segment.SetElement(3, value); }
        }

        public TimeCode DTM04_TimeCode
        {
            get { return this.Segment.GetElement(4).ToEnumFromEDIFieldValue<TimeCode>(); }
            set { this.Segment.SetElement(4, value.EDIFieldValue()); }
        }

        public DTPFormatQualifier DTM05_DateTimePeriodFormatQualifier
        {
            get { return this.Segment.GetElement(5).ToEnumFromEDIFieldValue<DTPFormatQualifier>(); }
            set { this.Segment.SetElement(5, value.EDIFieldValue()); }
        }

        public string DTM06_DateTimePeriod
        {
            get { return this.Segment.GetElement(6); }
            set { this.Segment.SetElement(6, value); }
        }
    }
}
