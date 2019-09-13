using System;
using System.Collections.Generic;
using System.Text;

namespace REFITyoutube
{
    public class PlayView
    {
       
    }
    //public class MakeUp
    //{
    //    public int Id { get; set; }
    //    public string Brand { get; set; }
    //    public string Name { get; set; }
    //    public string Price { get; set; }
    //    public object PriceSign { get; set; }
    //    public object Currency { get; set; }
    //    public string ImageLink { get; set; }
    //    public string ProductLink { get; set; }
    //    public string WebsiteLink { get; set; }
    //    public string Description { get; set; }
    //    public double? Rating { get; set; }
    //    public string Category { get; set; }
    //    public string ProductType { get; set; }
    //    public IList<object> TagList { get; set; }
    //    public DateTime CreatedAt { get; set; }
    //    public DateTime UpdatedAt { get; set; }
    //    public string ProductApiUrl { get; set; }
    //    public string ApiFeaturedImage { get; set; }
    //    public IList<ProductColor> ProductColors { get; set; }
    //}

    //public class ProductColor
    //{
    //    public string HexValue { get; set; }
    //    public string ColourName { get; set; }
    //}




    public class PageInfo
    {
        public int TotalResults { get; set; }
        public int ResultsPerPage { get; set; }
    }

    public class Id
    {
        public string Kind { get; set; }
        public string PlaylistId { get; set; }
    }

    public class Default
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Medium
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class High
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Thumbnails
    {
        public Default Default { get; set; }
        public Medium Medium { get; set; }
        public High High { get; set; }
    }

    public class Snippet
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Thumbnails Thumbnails { get; set; }
        public string ChannelTitle { get; set; }
        public string LiveBroadcastContent { get; set; }
    }

    public class Item
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public Id Id { get; set; }
        public Snippet Snippet { get; set; }
    }

    public class Example
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }
        public string RegionCode { get; set; }
        public PageInfo PageInfo { get; set; }
        public IList<Item> Items { get; set; }
    }


}
