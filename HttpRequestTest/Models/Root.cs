using System.Text.Json.Serialization;

namespace HttpRequestExamples.Models
{
    public class Root
    {
        [JsonPropertyName("source")]
        public string? source { get; set; }

        [JsonPropertyName("result")]
        public string? result { get; set; }

        [JsonPropertyName("postal_code")]
        public string? postal_code { get; set; }

        [JsonPropertyName("country")]
        public string? country { get; set; }

        [JsonPropertyName("country_iso_code")]
        public string? country_iso_code { get; set; }

        [JsonPropertyName("federal_district")]
        public string? federal_district { get; set; }

        [JsonPropertyName("region_fias_id")]
        public string? region_fias_id { get; set; }

        [JsonPropertyName("region_kladr_id")]
        public string? region_kladr_id { get; set; }

        [JsonPropertyName("region_iso_code")]
        public string? region_iso_code { get; set; }

        [JsonPropertyName("region_with_type")]
        public string? region_with_type { get; set; }

        [JsonPropertyName("region_type")]
        public string? region_type { get; set; }

        [JsonPropertyName("region_type_full")]
        public string? region_type_full { get; set; }

        [JsonPropertyName("region")]
        public string? region { get; set; }

        [JsonPropertyName("area_fias_id")]
        public object? area_fias_id { get; set; }

        [JsonPropertyName("area_kladr_id")]
        public object? area_kladr_id { get; set; }

        [JsonPropertyName("area_with_type")]
        public object? area_with_type { get; set; }

        [JsonPropertyName("area_type")]
        public object? area_type { get; set; }

        [JsonPropertyName("area_type_full")]
        public object? area_type_full { get; set; }

        [JsonPropertyName("area")]
        public object? area { get; set; }

        [JsonPropertyName("city_fias_id")]
        public object? city_fias_id { get; set; }

        [JsonPropertyName("city_kladr_id")]
        public object? city_kladr_id { get; set; }

        [JsonPropertyName("city_with_type")]
        public object? city_with_type { get; set; }

        [JsonPropertyName("city_type")]
        public object? city_type { get; set; }

        [JsonPropertyName("city_type_full")]
        public object? city_type_full { get; set; }

        [JsonPropertyName("city")]
        public object? city { get; set; }

        [JsonPropertyName("city_area")]
        public string? city_area { get; set; }

        [JsonPropertyName("city_district_fias_id")]
        public object? city_district_fias_id { get; set; }

        [JsonPropertyName("city_district_kladr_id")]
        public object? city_district_kladr_id { get; set; }

        [JsonPropertyName("city_district_with_type")]
        public string? city_district_with_type { get; set; }

        [JsonPropertyName("city_district_type")]
        public string? city_district_type { get; set; }

        [JsonPropertyName("city_district_type_full")]
        public string? city_district_type_full { get; set; }

        [JsonPropertyName("city_district")]
        public string? city_district { get; set; }

        [JsonPropertyName("settlement_fias_id")]
        public object? settlement_fias_id { get; set; }

        [JsonPropertyName("settlement_kladr_id")]
        public object? settlement_kladr_id { get; set; }

        [JsonPropertyName("settlement_with_type")]
        public object? settlement_with_type { get; set; }

        [JsonPropertyName("settlement_type")]
        public object? settlement_type { get; set; }

        [JsonPropertyName("settlement_type_full")]
        public object? settlement_type_full { get; set; }

        [JsonPropertyName("settlement")]
        public object? settlement { get; set; }

        [JsonPropertyName("street_fias_id")]
        public string? street_fias_id { get; set; }

        [JsonPropertyName("street_kladr_id")]
        public string? street_kladr_id { get; set; }

        [JsonPropertyName("street_with_type")]
        public string? street_with_type { get; set; }

        [JsonPropertyName("street_type")]
        public string? street_type { get; set; }

        [JsonPropertyName("street_type_full")]
        public string? street_type_full { get; set; }

        [JsonPropertyName("street")]
        public string? street { get; set; }

        [JsonPropertyName("house_fias_id")]
        public string? house_fias_id { get; set; }

        [JsonPropertyName("house_kladr_id")]
        public string? house_kladr_id { get; set; }

        [JsonPropertyName("house_cadnum")]
        public string? house_cadnum { get; set; }

        [JsonPropertyName("house_type")]
        public string? house_type { get; set; }

        [JsonPropertyName("house_type_full")]
        public string? house_type_full { get; set; }

        [JsonPropertyName("house")]
        public string? house { get; set; }

        [JsonPropertyName("block_type")]
        public object? block_type { get; set; }

        [JsonPropertyName("block_type_full")]
        public object? block_type_full { get; set; }

        [JsonPropertyName("block")]
        public object? block { get; set; }

        [JsonPropertyName("entrance")]
        public object? entrance { get; set; }

        [JsonPropertyName("floor")]
        public object? floor { get; set; }

        [JsonPropertyName("flat_fias_id")]
        public string? flat_fias_id { get; set; }

        [JsonPropertyName("flat_cadnum")]
        public string? flat_cadnum { get; set; }

        [JsonPropertyName("flat_type")]
        public string? flat_type { get; set; }

        [JsonPropertyName("flat_type_full")]
        public string? flat_type_full { get; set; }

        [JsonPropertyName("flat")]
        public string? flat { get; set; }

        [JsonPropertyName("flat_area")]
        public string? flat_area { get; set; }

        [JsonPropertyName("square_meter_price")]
        public string? square_meter_price { get; set; }

        [JsonPropertyName("flat_price")]
        public string? flat_price { get; set; }

        [JsonPropertyName("postal_box")]
        public object? postal_box { get; set; }

        [JsonPropertyName("fias_id")]
        public string? fias_id { get; set; }

        [JsonPropertyName("fias_code")]
        public string? fias_code { get; set; }

        [JsonPropertyName("fias_level")]
        public string? fias_level { get; set; }

        [JsonPropertyName("fias_actuality_state")]
        public string? fias_actuality_state { get; set; }

        [JsonPropertyName("kladr_id")]
        public string? kladr_id { get; set; }

        [JsonPropertyName("capital_marker")]
        public string? capital_marker { get; set; }

        [JsonPropertyName("okato")]
        public string? okato { get; set; }

        [JsonPropertyName("oktmo")]
        public string? oktmo { get; set; }

        [JsonPropertyName("tax_office")]
        public string? tax_office { get; set; }

        [JsonPropertyName("tax_office_legal")]
        public string? tax_office_legal { get; set; }

        [JsonPropertyName("timezone")]
        public string? timezone { get; set; }

        [JsonPropertyName("geo_lat")]
        public string? geo_lat { get; set; }

        [JsonPropertyName("geo_lon")]
        public string? geo_lon { get; set; }

        [JsonPropertyName("beltway_hit")]
        public string? beltway_hit { get; set; }

        [JsonPropertyName("beltway_distance")]
        public object? beltway_distance { get; set; }

        [JsonPropertyName("qc_geo")]
        public int? qc_geo { get; set; }

        [JsonPropertyName("qc_complete")]
        public int? qc_complete { get; set; }

        [JsonPropertyName("qc_house")]
        public int? qc_house { get; set; }

        [JsonPropertyName("qc")]
        public int? qc { get; set; }

        [JsonPropertyName("unparsed_parts")]
        public object? unparsed_parts { get; set; }

        [JsonPropertyName("metro")]
        public List<Metro>? metro { get; set; }
    }
}

