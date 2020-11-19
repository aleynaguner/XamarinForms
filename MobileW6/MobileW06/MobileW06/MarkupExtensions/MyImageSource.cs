using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileW06.MarkupExtensions
{
    [ContentProperty("Source")]
    public class MyImageSource : IMarkupExtension
    {
        public string ImagePath { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ImagePath!=null)
            {
                return ImageSource.FromResource(ImagePath);
            }

            return null;
        }
    }


}
