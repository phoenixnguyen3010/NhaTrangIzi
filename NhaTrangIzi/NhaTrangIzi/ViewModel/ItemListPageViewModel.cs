using System.Collections.Generic;

namespace NhaTrangIzi.ViewModel
{
    public class ItemListPageViewModel
    {
        public ItemListPageViewModel()
        {
            News = new List<NewsItem>()
            {
                new NewsItem()
                {
                    Header = "Header 1",
                    Text = "Text 1"
                },
                new NewsItem()
                {
                    Header = "Header 2",
                    Text = "Text 2"
                },
                 new NewsItem()
                {
                    Header = "Header 3",
                    Text = "Text 3"
                },
                  new NewsItem()
                {
                    Header = "Header 4",
                    Text = "Text 4"
                }
            };
        }

        public List<NewsItem> News { get; set; }
    }

    public class NewsItem
    {
        public string Header { get; set; }
        public string Text { get; set; }
    }
}