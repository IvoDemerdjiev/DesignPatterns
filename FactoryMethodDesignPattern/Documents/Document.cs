namespace FactoryMethodDesignPattern.Documents
{
    using System.Collections.Generic;

    using Pages;

    public abstract class Document
    {
        private List<Page> pages = new List<Page>();

        protected Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return pages; }
        }

        public abstract void CreatePages();
    }
}
