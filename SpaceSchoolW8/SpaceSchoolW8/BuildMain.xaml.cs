using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SpaceSchool;

// Il modello di elemento per la pagina base è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=234237

namespace SpaceSchoolW8
{
    /// <summary>
    /// Pagina base che fornisce caratteristiche comuni alla maggior parte delle applicazioni.
    /// </summary>
    public sealed partial class BuildMain : SpaceSchoolW8.Common.LayoutAwarePage
    {
        public BuildMain()
        {
            this.InitializeComponent();

            Rocket _rocket = new Rocket();

        }

        /// <summary>
        /// Popola la pagina con il contenuto passato durante la navigazione. Vengono inoltre forniti eventuali stati
        /// salvati durante la ricreazione di una pagina in una sessione precedente.
        /// </summary>
        /// <param name="navigationParameter">Valore del parametro passato a
        /// <see cref="Frame.Navigate(Type, Object)"/> quando la pagina è stata inizialmente richiesta.
        /// </param>
        /// <param name="pageState">Dizionario di stato mantenuto da questa pagina nel corso di una sessione
        /// precedente. Il valore è null la prima volta che viene visitata una pagina.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Mantiene lo stato associato a questa pagina in caso di sospensione dell'applicazione o se la
        /// viene scartata dalla cache di navigazione. I valori devono essere conformi ai requisiti di
        /// serializzazione di <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">Dizionario vuoto da popolare con uno stato serializzabile.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
