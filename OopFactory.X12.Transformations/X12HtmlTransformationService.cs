﻿namespace OopFactory.X12.Transformations
{
    using System.Xml;
    using System.Xml.Xsl;

    public class X12HtmlTransformationService : X12TransformationService
    {
        private readonly ITransformationService preProcessor;

        private static XslCompiledTransform transform;

        public X12HtmlTransformationService(ITransformationService preProcessor)
            : base(preProcessor)
        {
            this.preProcessor = preProcessor;
        }

        protected override XslCompiledTransform GetTransform()
        {
            if (transform == null)
            {
                transform = new XslCompiledTransform();
                transform.Load(XmlReader.Create(TransformationStreamFactory.GetHtmlTransformationStream()));
            }

            return transform;
        }
    }
}