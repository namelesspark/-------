using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G24W1502WPFRest;

public record class Game(
    int id,
    string title,
    string thumbnail,
    string short_description,
    string game_url,
    string genre,
    string platform,
    string publisher,
    string developer,
    string release_date,
    string freetogame_profile_url
);
