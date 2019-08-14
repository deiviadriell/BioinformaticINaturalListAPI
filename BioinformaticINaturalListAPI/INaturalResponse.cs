using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticINaturalListAPI
{
    class INaturalResponse
    {
    }
    [DataContract]
    public class INaturalResponseObs
    {
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "observed_on")]
        public string observed_on { get; set; }
        [DataMember(Name = "description")]
        public string description { get; set; }
        [DataMember(Name = "latitude")]
        public string latitude { get; set; }
        [DataMember(Name = "longitude")]
        public string longitude { get; set; }
        [DataMember(Name = "map_scale")]
        public string map_scale { get; set; }
        [DataMember(Name = "timeframe")]
        public string timeframe { get; set; }
        [DataMember(Name = "species_guess")]
        public string species_guess { get; set; }
        [DataMember(Name = "user_id")]
        public string user_id { get; set; }
        [DataMember(Name = "taxon_id")]
        public string taxon_id { get; set; }
        [DataMember(Name = "created_at")]
        public string created_at { get; set; }
        [DataMember(Name = "updated_at")]
        public string updated_at { get; set; }
        [DataMember(Name = "place_guess")]
        public string place_guess { get; set; }
        [DataMember(Name = "id_please")]
        public string id_please { get; set; }
        [DataMember(Name = "observed_on_string")]
        public string observed_on_string { get; set; }
        [DataMember(Name = "iconic_taxon_id")]
        public string iconic_taxon_id { get; set; }
        [DataMember(Name = "num_identification_agreements")]
        public string num_identification_agreements { get; set; }
        [DataMember(Name = "num_identification_disagreements")]
        public string num_identification_disagreements { get; set; }
        [DataMember(Name = "time_observed_at")]
        public string time_observed_at { get; set; }
        [DataMember(Name = "time_zone")]
        public string time_zone { get; set; }
        [DataMember(Name = "location_is_exact")]
        public string location_is_exact { get; set; }
        [DataMember(Name = "delta")]
        public string delta { get; set; }
        [DataMember(Name = "positional_accuracy")]
        public string positional_accuracy { get; set; }
        [DataMember(Name = "geoprivacy")]
        public string geoprivacy { get; set; }
        [DataMember(Name = "quality_grade")]
        public string quality_grade { get; set; }
        [DataMember(Name = "positioning_method")]
        public string positioning_method { get; set; }
        [DataMember(Name = "positioning_device")]
        public string positioning_device { get; set; }
        [DataMember(Name = "out_of_range")]
        public string out_of_range { get; set; }
        [DataMember(Name = "license")]
        public string license { get; set; }
        [DataMember(Name = "uri")]
        public string uri { get; set; }
        [DataMember(Name = "observation_photos_count")]
        public string observation_photos_count { get; set; }
        [DataMember(Name = "comments_count")]
        public string comments_count { get; set; }
        [DataMember(Name = "zic_time_zone")]
        public string zic_time_zone { get; set; }
        [DataMember(Name = "oauth_application_id")]
        public string oauth_application_id { get; set; }
        [DataMember(Name = "observation_sounds_count")]
        public string observation_sounds_count { get; set; }
        [DataMember(Name = "identifications_count")]
        public string identifications_count { get; set; }
        [DataMember(Name = "captive")]
        public string captive { get; set; }
        [DataMember(Name = "community_taxon_id")]
        public string community_taxon_id { get; set; }
        [DataMember(Name = "site_id")]
        public string site_id { get; set; }
        [DataMember(Name = "old_uuid")]
        public string old_uuid { get; set; }
        [DataMember(Name = "public_positional_accuracy")]
        public string public_positional_accuracy { get; set; }
        [DataMember(Name = "mappable")]
        public string mappable { get; set; }
        [DataMember(Name = "cached_votes_total")]
        public string cached_votes_total { get; set; }
        [DataMember(Name = "last_indexed_at")]
        public string last_indexed_at { get; set; }
        [DataMember(Name = "uuid")]
        public string uuid { get; set; }
        [DataMember(Name = "short_description")]
        public string short_description { get; set; }
        [DataMember(Name = "user_login")]
        public string user_login { get; set; }
        [DataMember(Name = "iconic_taxon_name")]
        public string iconic_taxon_name { get; set; }
        [DataMember(Name = "tag_list")]
        public List<string> tag_list { get; set; }
        [DataMember(Name = "faves_count")]
        public string faves_count { get; set; }
        [DataMember(Name = "created_at_utc")]
        public string created_at_utc { get; set; }
        [DataMember(Name = "updated_at_utc")]
        public string updated_at_utc { get; set; }
        [DataMember(Name = "time_observed_at_utc")]
        public string time_observed_at_utc { get; set; }
        [DataMember(Name = "owners_identification_from_vision")]
        public string owners_identification_from_vision { get; set; }
        [DataMember(Name = "coordinates_obscured")]
        public string coordinates_obscured { get; set; }
        [DataMember(Name = "taxon")]
        public taxon taxon { get; set; }
        [DataMember(Name = "iconic_taxon")]
        public iconic_taxon iconic_taxon { get; set; }
        [DataMember(Name = "user")]
        public iconic_taxon user { get; set; }
        [DataMember(Name = "photos")]
        public List<photos> photos { get; set; }
    }
    [DataContract]
    public class taxon
    {
        [DataMember(Name = "is_active")]
        public string is_active { get; set; }
        [DataMember(Name = "ancestry")]
        public string ancestry { get; set; }
        [DataMember(Name = "min_species_ancestry")]
        public string min_species_ancestry { get; set; }
        [DataMember(Name = "endemic")]
        public string endemic { get; set; }
        [DataMember(Name = "iconic_taxon_id")]
        public string iconic_taxon_id { get; set; }
        [DataMember(Name = "threatened")]
        public string threatened { get; set; }
        [DataMember(Name = "rank_level")]
        public string rank_level { get; set; }
        [DataMember(Name = "introduced")]
        public string introduced { get; set; }
        [DataMember(Name = "native")]
        public string native { get; set; }
        [DataMember(Name = "parent_id")]
        public string parent_id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "rank")]
        public string rank { get; set; }
        [DataMember(Name = "extinct")]
        public string extinct { get; set; }
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "ancestor_ids")]
        public string ancestor_ids { get; set; }
        [DataMember(Name = "taxon_schemes_count")]
        public string taxon_schemes_count { get; set; }
        [DataMember(Name = "wikipedia_url")]
        public string wikipedia_url { get; set; }
        [DataMember(Name = "current_synonymous_taxon_ids")]
        public string current_synonymous_taxon_ids { get; set; }
        [DataMember(Name = "created_at")]
        public string created_at { get; set; }
        [DataMember(Name = "taxon_changes_count")]
        public string taxon_changes_count { get; set; }
        [DataMember(Name = "complete_species_count")]
        public string complete_species_count { get; set; }
        [DataMember(Name = "observations_count")]
        public string observations_count { get; set; }
        [DataMember(Name = "flag_counts")]
        public List<flag_counts> flag_counts { get; set; }
        [DataMember(Name = "atlas_id")]
        public string atlas_id { get; set; }
        [DataMember(Name = "complete_rank")]
        public string complete_rank { get; set; }
        [DataMember(Name = "default_photo")]
        public default_photo default_photo { get; set; }
        [DataMember(Name = "iconic_taxon_name")]
        public string iconic_taxon_name { get; set; }
        [DataMember(Name = "preferred_common_name")]
        public string preferred_common_name { get; set; }
    }
    [DataContract]
    public class iconic_taxon
    {
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "rank")]
        public string rank { get; set; }
        [DataMember(Name = "rank_level")]
        public string rank_level { get; set; }
        [DataMember(Name = "ancestry")]
        public string ancestry { get; set; }
    }
    [DataContract]
    public class default_photo
    {
        [DataMember(Name = "square_url")]
        public string square_url { get; set; }
        [DataMember(Name = "attribution")]
        public string attribution { get; set; }
        [DataMember(Name = "flags")]
        public List<string> flags { get; set; }
        [DataMember(Name = "medium_url")]
        public string medium_url { get; set; }
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "license_code")]
        public string license_code { get; set; }
        [DataMember(Name = "original_dimensions")]
        public original_dimensions original_dimensions { get; set; }
        [DataMember(Name = "url")]
        public string url { get; set; }
    }
    [DataContract]
    public class flag_counts
    {
        [DataMember(Name = "unresolved")]
        public string unresolved { get; set; }
        [DataMember(Name = "resolved")]
        public string resolved { get; set; }
    }
    [DataContract]
    public class original_dimensions
    {
        [DataMember(Name = "width")]
        public string width { get; set; }
        [DataMember(Name = "height")]
        public string height { get; set; }
    }
    [DataContract]
    public class photos
    {
        [DataMember(Name = "id")]
        public string id { get; set; }
        [DataMember(Name = "user_id")]
        public string user_id { get; set; }
        [DataMember(Name = "native_photo_id")]
        public string native_photo_id { get; set; }
        [DataMember(Name = "square_url")]
        public string square_url { get; set; }
        [DataMember(Name = "thumb_url")]
        public string thumb_url { get; set; }
        [DataMember(Name = "small_url")]
        public string small_url { get; set; }
        [DataMember(Name = "medium_url")]
        public string medium_url { get; set; }
        [DataMember(Name = "large_url")]
        public string large_url { get; set; }
        [DataMember(Name = "created_at")]
        public string created_at { get; set; }
        [DataMember(Name = "updated_at")]
        public string updated_at { get; set; }
        [DataMember(Name = "native_page_url")]
        public string native_page_url { get; set; }
        [DataMember(Name = "native_username")]
        public string native_username { get; set; }
        [DataMember(Name = "native_realname")]
        public string native_realname { get; set; }
        [DataMember(Name = "license")]
        public string license { get; set; }
        [DataMember(Name = "subtype")]
        public string subtype { get; set; }
        [DataMember(Name = "native_original_image_url")]
        public string native_original_image_url { get; set; }
        [DataMember(Name = "license_code")]
        public string license_code { get; set; }
        [DataMember(Name = "attribution")]
        public string attribution { get; set; }
        [DataMember(Name = "license_name")]
        public string license_name { get; set; }
        [DataMember(Name = "license_url")]
        public string license_url { get; set; }
        [DataMember(Name = "type")]
        public string type { get; set; }


    }

}
