using System;
using System.Collections.Generic;

namespace GetAPhoto
{
  public class Urls
  {
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
  }

  public class Links
  {
    public string self { get; set; }
    public string html { get; set; }
    public string download { get; set; }
    public string download_location { get; set; }
  }

  public class Links2
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class User
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links2 links { get; set; }
    public ProfileImage profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class Exif
  {
    public string make { get; set; }
    public string model { get; set; }
    public string exposure_time { get; set; }
    public string aperture { get; set; }
    public string focal_length { get; set; }
    public int? iso { get; set; }
  }

  public class Position
  {
    public double? latitude { get; set; }
    public double? longitude { get; set; }
  }

  public class Location
  {
    public string title { get; set; }
    public string name { get; set; }
    public string city { get; set; }
    public string country { get; set; }
    public Position position { get; set; }
  }

  public class Type
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Category
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Subcategory
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Ancestry
  {
    public Type type { get; set; }
    public Category category { get; set; }
    public Subcategory subcategory { get; set; }
  }

  public class Urls2
  {
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
  }

  public class Links3
  {
    public string self { get; set; }
    public string html { get; set; }
    public string download { get; set; }
    public string download_location { get; set; }
  }

  public class Links4
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage2
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class User2
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links4 links { get; set; }
    public ProfileImage2 profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class CoverPhoto
  {
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public string description { get; set; }
    public string alt_description { get; set; }
    public Urls2 urls { get; set; }
    public Links3 links { get; set; }
    public List<object> categories { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public List<object> current_user_collections { get; set; }
    public User2 user { get; set; }
  }

  public class Source
  {
    public Ancestry ancestry { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public string description { get; set; }
    public string meta_title { get; set; }
    public string meta_description { get; set; }
    public CoverPhoto cover_photo { get; set; }
  }

  public class Tag
  {
    public string type { get; set; }
    public string title { get; set; }
    public Source source { get; set; }
  }

  public class Links5
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage3
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class Sponsor
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links5 links { get; set; }
    public ProfileImage3 profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class Sponsorship
  {
    public string impressions_id { get; set; }
    public string tagline { get; set; }
    public Sponsor sponsor { get; set; }
  }

  public class Type2
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Category2
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Subcategory2
  {
    public string slug { get; set; }
    public string pretty_slug { get; set; }
  }

  public class Ancestry2
  {
    public Type2 type { get; set; }
    public Category2 category { get; set; }
    public Subcategory2 subcategory { get; set; }
  }

  public class Urls3
  {
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
  }

  public class Links6
  {
    public string self { get; set; }
    public string html { get; set; }
    public string download { get; set; }
    public string download_location { get; set; }
  }

  public class Links7
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage4
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class User3
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links7 links { get; set; }
    public ProfileImage4 profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class CoverPhoto2
  {
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public string description { get; set; }
    public string alt_description { get; set; }
    public Urls3 urls { get; set; }
    public Links6 links { get; set; }
    public List<object> categories { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public List<object> current_user_collections { get; set; }
    public User3 user { get; set; }
  }

  public class Source2
  {
    public Ancestry2 ancestry { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public string description { get; set; }
    public string meta_title { get; set; }
    public string meta_description { get; set; }
    public CoverPhoto2 cover_photo { get; set; }
  }

  public class Tag2
  {
    public string type { get; set; }
    public string title { get; set; }
    public Source2 source { get; set; }
  }

  public class Links8
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string related { get; set; }
  }

  public class Links9
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage5
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class User4
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public object twitter_username { get; set; }
    public object portfolio_url { get; set; }
    public object bio { get; set; }
    public object location { get; set; }
    public Links9 links { get; set; }
    public ProfileImage5 profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class Urls4
  {
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
  }

  public class Links10
  {
    public string self { get; set; }
    public string html { get; set; }
    public string download { get; set; }
    public string download_location { get; set; }
  }

  public class Links11
  {
    public string self { get; set; }
    public string html { get; set; }
    public string photos { get; set; }
    public string likes { get; set; }
    public string portfolio { get; set; }
    public string following { get; set; }
    public string followers { get; set; }
  }

  public class ProfileImage6
  {
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
  }

  public class User5
  {
    public string id { get; set; }
    public DateTime updated_at { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string twitter_username { get; set; }
    public string portfolio_url { get; set; }
    public string bio { get; set; }
    public string location { get; set; }
    public Links11 links { get; set; }
    public ProfileImage6 profile_image { get; set; }
    public string instagram_username { get; set; }
    public int total_collections { get; set; }
    public int total_likes { get; set; }
    public int total_photos { get; set; }
    public bool accepted_tos { get; set; }
  }

  public class CoverPhoto3
  {
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public string description { get; set; }
    public string alt_description { get; set; }
    public Urls4 urls { get; set; }
    public Links10 links { get; set; }
    public List<object> categories { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public List<object> current_user_collections { get; set; }
    public User5 user { get; set; }
  }

  public class Urls5
  {
    public string raw { get; set; }
    public string full { get; set; }
    public string regular { get; set; }
    public string small { get; set; }
    public string thumb { get; set; }
  }

  public class PreviewPhoto
  {
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Urls5 urls { get; set; }
  }

  public class Result
  {
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public DateTime published_at { get; set; }
    public DateTime updated_at { get; set; }
    public bool curated { get; set; }
    public bool featured { get; set; }
    public int total_photos { get; set; }
    public bool @private { get; set; }
    public string share_key { get; set; }
    public List<Tag2> tags { get; set; }
    public Links8 links { get; set; }
    public User4 user { get; set; }
    public CoverPhoto3 cover_photo { get; set; }
    public List<PreviewPhoto> preview_photos { get; set; }
  }

  public class RelatedCollections
  {
    public int total { get; set; }
    public string type { get; set; }
    public List<Result> results { get; set; }
  }

  public class APhoto
  {
    public string id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string color { get; set; }
    public object description { get; set; }
    public string alt_description { get; set; }
    public Urls urls { get; set; }
    public Links links { get; set; }
    public List<object> categories { get; set; }
    public int likes { get; set; }
    public bool liked_by_user { get; set; }
    public List<object> current_user_collections { get; set; }
    public User user { get; set; }
    public Exif exif { get; set; }
    public Location location { get; set; }
    public List<Tag> tags { get; set; }
    public Sponsorship sponsorship { get; set; }
    public RelatedCollections related_collections { get; set; }
    public int views { get; set; }
    public int downloads { get; set; }
  }
}