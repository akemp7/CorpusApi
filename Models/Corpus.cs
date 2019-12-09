using System.ComponentModel.DataAnnotations;
namespace CorpusApi.Models
{
    public class Corpus{
        public int CorpusId {get; set; }
        public string Summary {get; set; }
    }
}