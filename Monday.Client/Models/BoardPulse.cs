using Newtonsoft.Json;
using System.Collections.Generic;

namespace Monday.Client.Models
{
    public class BoardPulse
    {
        public Pulse Pulse { get; set; }

        [JsonProperty("board_meta")]
        public BoardMeta BoardMeta { get; set; }

        [JsonProperty("column_values")]
        public List<BoardColumnValue> ColumnValues { get; set; }
    }
}