using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace WheaterAppi.Model
{
    public abstract class WebScraperBase<T> : IDisposable
    {
        private WebClient _client;
        private HtmlDocument _document;

        private readonly string _pageUrl;

        public WebScraperBase(string pageUrl)
        {
            _pageUrl = pageUrl;
            _client = new WebClient();
        }

        protected HtmlDocument Document
        {
            get
            {
                if (_document == null)
                {
                    var response = _client.DownloadString(_pageUrl);
                    _document = new HtmlDocument();
                    _document.LoadHtml(response);
                }
                return _document;
            }
        }

        public abstract T Execute();

        public void Dispose()
        {
            if (_client != null)
            {
                _client.Dispose();
                _client = null;
            }
        }
    }
}
