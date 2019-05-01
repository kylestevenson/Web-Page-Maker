using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleStevensonFinalProject
{
    class Section
    {
        private string heading;
        private string subHeading;
        private string content;
        private string heroColor;
        public Section(string heading, string subHeading, string content, string heroColor)
        {
            Heading = heading;
            SubHeading = subHeading;
            Content = content;
            HeroColor = heroColor;
        }
        //getters, setters
        public string Heading
        {
            get
            {
                return heading;
            }
            set
            {
                heading = value;
            }
        }
        public string SubHeading
        {
            get
            {
                return subHeading;
            }
            set
            {
                subHeading = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public string HeroColor
        {
            get
            {
                return heroColor;
            }
            set
            {
                heroColor = value;
            }
        }
    }
}
