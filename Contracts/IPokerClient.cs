using CoinPokerCommonLib.Models;
using CoinPokerCommonLib.Models.Action;
using CoinPokerCommonLib.Models.Game.TournamentOption;
using CoinPokerCommonLib.Models.OfferAction;
using Hik.Communication.ScsServices.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPokerCommonLib
{
    public interface IPokerClient
    {   
        /// <summary>
        /// Nowa wiadomość czatu
        /// </summary>
        void OnGameTableUserMessage(TableModel table, UserModel user, string message);

        /// <summary>
        /// Zmiany dotyczące ilości graczy, listy graczy
        /// </summary>
        void OnNormalGameModelUpdate(NormalGameModel table);

        /// <summary>
        /// Zmiany dotyczące ilości graczy, listy graczy, wszelkie zmiany turniejowe
        /// </summary>
        void OnTournamentGameModelUpdate(ITournamentGameModel table);

        /// <summary>
        /// Aktializacja listy stolow do turnieju
        /// </summary>
        /// <param name="table"></param>
        /// <param name="tableList"></param>
        void OnTournamentTableListUpdate(ITournamentGameModel table, List<TableModel> tableList);

        /// <summary>
        /// Otwieranie okna gry
        /// </summary>
        /// <param name="table"></param>
        void OnTableOpenWindow(TableModel table);

        /// <summary>
        /// Gracz zostaje przeniesiony do innego stołu
        /// </summary>
        /// <param name="table"></param>
        void OnGameTableUserMove(UserModel user, TableModel table, TableModel newTable);

        /// <summary>
        /// Pokazanie wiadomości systemowej na danym stole
        /// </summary>
        /// <param name="table"></param>
        /// <param name="status"></param>
        /// <param name="messageModel"></param>
        void OnGameTableSystemMessage(TableModel table, TableMessageModel.Status status, TableMessageModel messageModel);

        /// <summary>
        /// Użytkownik wstał od stołu
        /// </summary>
        void OnGamePlayerStandup(TableModel table, PlayerModel player);

        /// <summary>
        /// Użytkownik usiadł
        /// </summary>
        void OnGamePlayerSitdown(TableModel table, PlayerModel player);

        /// <summary>
        /// Gracz zmienia swój status
        /// </summary>
        /// <param name="table"></param>
        /// <param name="player"></param>
        /// <param name="status"></param>
        void OnGamePlayerUpdate(TableModel table, PlayerModel player);

        /// <summary>
        /// Nowe rozdanie, czysci stol, karty
        /// </summary>
        void OnGameTableClear(TableModel table);

        /// <summary>
        /// Otrzymujemy historie stolu (zerwne polaczenie, dolaczenie do listy obserwatorow)
        /// </summary>
        void OnGameTableHitory(TableModel table, ObservableCollection<BaseAction> tableHistory);

        /// <summary>
        /// Użytkownik ma czas na wykonanie akcji
        /// </summary>
        void OnGameActionOffer(TableModel table, BaseOfferAction action);

        /// <summary>
        /// Użytkownik wykonuje jakąś akcję
        /// </summary>
        void OnGameActionTrigger(TableModel table, BaseAction action);

        /// <summary>
        /// Pomyślna autoryzacja użytkownika -> Logowanie
        /// </summary>
        void OnLoginSuccessfull(long client_id, UserModel user);

        /// <summary>
        /// Odbieramy pakiet danych statystyk
        /// </summary>
        void OnGetStatsInfo(StatsModel data);

        /// <summary>
        /// Uzytkownik zmienil avatar
        /// </summary>
        /// <param name="user"></param>
        void OnUserAvatarChanged(UserModel user);

        /// <summary>
        /// Pokazuje okno z informacją o nowym transferze pieniędzy
        /// </summary>
        /// <param name="transfer"></param>
        void OnDepositInfo(TransferModel transfer);

        /// <summary>
        /// Wiadomość od serwera
        /// </summary>
        /// <param name="message"></param>
        void OnMessage(string message);

        /// <summary>
        /// Wysyła reklamę z danym url i daną grafiką
        /// </summary>
        /// <param name="url"></param>
        /// <param name="imageUrl"></param>
        void OnGetAdvertising(AdvertisingModel adv);
    }
}
