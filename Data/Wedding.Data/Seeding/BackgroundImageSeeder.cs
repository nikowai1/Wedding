namespace Wedding.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Wedding.Data.Models;

    public class BackgroundImageSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BackgroundImage.Any())
            {
                return;
            }

            await dbContext.AddAsync(new BackgroundImage { ImageUrl = "https://lh3.googleusercontent.com/GUY9yPOd5FYXD8DIRgncaIofPcg0_TdIse2pRu4I05LnZpMK_LWmbks7Fg4bT2G1JWb-4mglWafQjdNGAGlEMBSOX-2wfZCxZaaxS5D8XU7r5-f_u2laOclLoFkNEviAbAiNOgOgxxW0yqw0UNFsWlliKKmh7QTkqRaiLBrd4LetkN-LR-ba01USmUjIiVxXoux-gkGA7LnvlaE9KO4ARyQFVil0Xz2rW1XBzz6L4lZmJ0JtmN1nQGoODk3KTGEW1YuC4fWEDh1Txm4VFzAgBUbfdyzSCsrItv8sDNDN6VFBH_m1pFu_8frQw1fuGHdpmTuVOlaW1jWX63myB-2OZz5mFwc1K-GLYhi53-EJmrl6xVlucN3MZ2YcRvbRLwHiVmdWZdStmTepn0SU8Ijvia54B04bUVJ8ZuNF5Oi9qCoQAPUy-QpBjmDJN_-lRM_br5LYco4ciW5WKaoBrcgtz93ehWv-4FRBRDKEZAZMZynEW3lBApE1078hKT-Wu8OEOq9xCfc3nYj05PeucmBrlu_C_VnTwlHLZ-_axJYp4vcbR3qGhGES0dLphAdnlxq1ZDGxH2T537vZh7atJcsp-3Rp94heXW_cRO8GzQzdCnglyOWF6mq5zJpmfvvIFdvCOszYnX6AWakAYtrp64WvgiqSBIEqX6-WAARwwminrhQqbP87rlFO7E9069t9wA=w1677-h943-no?authuser=0" });
        }
    }
}
