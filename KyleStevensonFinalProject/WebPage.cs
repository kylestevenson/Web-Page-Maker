using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleStevensonFinalProject
{
    class WebPage
    {
        private string title;
        private string subTitle;
        private string titleColor;
        private string titleSize;
        private string bgColor;
        private string fontFamily;
        private string fontSize;
        public List<Section> sectionList = new List<Section>();
        private string page;
        private string sectionContent;
        private string sectionColor;

        public WebPage(string title, string subTitle, string titleColor, string titleSize, string bgColor, string fontFamily, string fontSize)
        {
            Title = title;
            SubTitle = subTitle;
            TitleColor = titleColor;
            TitleSize = titleSize;
            BgColor = bgColor;
            FontFamily = fontFamily;
            FontSize = fontSize;
        }
        public void CreatePage()
        {
            //set up title banner color
            titleColor = SetHeroColor(TitleColor);
            //provide proper css class for selected banner size
            if(titleSize == "Large")
            {
                titleSize = "is-large";
            }
            else if(titleSize == "Fullheight")
            {
                titleSize = "is-fullheight";
            }
            else
            {
                titleSize = "is-medium";
            }
            //set up font-family style
            if(fontFamily == "Default")
            {
                fontFamily = @"/* Using Bulma Default font-family (Segoe UI). */";
            }
            else
            {
                fontFamily = $@"body{{
                font-family: {fontFamily};
                }}";
            }
            //set up font-size style
            if(fontSize == "Default")
            {
                fontSize = @"/* Using Bulma Default font-size (16px). */";
            }
            else
            {
                fontSize = $@"p{{
                font-size: {fontSize};
                }}";
            }
            //set up sections
            SetSectionContent();

            //create page
            page = $@"<!DOCTYPE html>
<html>
    <head>
        <meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <title>{title}</title>
        <!-- Bulma was used as a CSS framework for this webpage.  Visit https://bulma.io/documentation/ for reference and to further customize your style! -->
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.2/css/bulma.css"">
        <!--Page style, add your own or adjust the style below! -->
        <style>
            html{{
                background-color: {bgColor};
                }}
            {fontFamily}
            {fontSize}
        </style>
    </head>
    <body>
        <!-- Page title -->
        <section class=""hero {titleColor} {titleSize} is-bold"">
            <div class=""hero-body"">
                <div class=""container has-text-centered"">
                    <h1 class=""title"">{title}</h1>
                    <h2 class=""subtitle"">{subTitle}</h2>
                </div>
            </div>
        </section>
        {sectionContent}
        <!--Footer content -->
        <footer class=""footer"">
            <div class=""content has-text-centered has-text-weight-light"">
            This webpage was created using Web Page Maker, developed by Kyle Stevenson.
            </div>
        </footer>
    </body>
</html>";
        }
        //provide proper css class for selected banner color
        private string SetHeroColor(string heroColor)
        {
            switch (heroColor)
            {
                case "Default":
                    return "is-primary";
                case "Blue":
                    return "is-info";
                case "Green":
                    return "is-success";
                case "Yellow":
                    return "is-warning";
                case "Red":
                    return "is-danger";
                case "Light":
                    return "is-light";
                case "Dark":
                    return "is-dark";
                default:
                    return "";

            }
        }
        //create section
        private void SetSectionContent()
        {
            sectionContent = $@"<!-- Main body content sections -->";
            for (int i = 0; i < sectionList.Count; i++)
            {
                //if no hero color, is section - provides correct css class
                if (sectionList[i].HeroColor == "None")
                {
                    sectionColor = "section";
                    sectionContent += $@"
        <section class=""{sectionColor}"">
            <div class=""container"">
                <h1 class=""title"">{sectionList[i].Heading}</h1>
                <h2 class=""subtitle"">{sectionList[i].SubHeading}</h2>
                <div class=""content"">
                    <p>{sectionList[i].Content}</p>
                </div>
            </div>
        </section>";
                }
                else
                {
                    //if has hero color, is hero - provides correct css class
                    sectionColor = SetHeroColor(sectionList[i].HeroColor);
                    sectionContent += $@"
        <section class=""hero {sectionColor}"">
            <div class=""hero-body"">
                <div class=""container"">
                    <h1 class=""title"">{sectionList[i].Heading}</h1>
                    <h2 class=""subtitle"">{sectionList[i].SubHeading}</h2>
                    <div class=""content"">
                        <p>{sectionList[i].Content}</p>
                    </div>
                </div>
            </div>
        </section>";
                }

            }
        }
        //add new section object to sectionList
        public void AddSection(Section section)
        {
            sectionList.Add(section);
        }
        //getters, setters
        public string Page
        {
            get
            {
                return page;
            }
        }
        
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string SubTitle
        {
            get
            {
                return subTitle;
            }
            set
            {
                subTitle = value;
            }
        }
        public string BgColor
        {
            get
            {
                return bgColor;
            }
            set
            {
                bgColor = value;
            }
        }
        public string TitleColor
        {
            get
            {
                return titleColor;
            }
            set
            {
                titleColor = value;
            }
        }
        public string TitleSize
        {
            get
            {
                return titleSize;
            }
            set
            {
                titleSize = value;
            }
        }
        public string FontFamily
        {
            get
            {
                return fontFamily;
            }
            set
            {
                fontFamily = value;
            }
        }
        public string FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
            }
        }
        
    }
}
