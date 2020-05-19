using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrente._4j
{
    class Program
    {
        static void Main(string[] args)
        {
            Banca Generali = new Banca("Generali", "via Mameli 12");
            Persona Paolo = new Persona("Paolo", "Rossi", "via Garibaldi 23", "3245698450", "paolorossi@gmail.com", new DateTime(1978, 05, 13, 12, 45, 00));
            Persona Luca = new Persona("Luca", "Bianchi", "via Mazzini 24", "3390890678", "lucabianchi@gmail.com", new DateTime(1980, 08, 10, 04, 05, 20));
            Persona Ciccio = new Persona("Ciccio", "Caputo", "Via col vento", "3273936249", "cicciocaputo@gmail.com", new DateTime(2001, 03, 09, 09, 03, 01));
            Persona personacreata = new Persona("", "", "", "", "", new DateTime(0000 / 01 / 01));
            ContoCorrente contocreato = new ContoCorrente(personacreata, 0, 50, 0.0, "IT88A030901651000050560130");
            Conto_Online ContoCreatoOnline = new Conto_Online(50.00, personacreata, 0, 50, 0.0, "IT88A030901651000050570170", "", "");
            ContoCorrente ContoPaolo = new ContoCorrente(Paolo, 0, 50, 200000.00, "IT88A030901651000050570131");
            ContoCorrente ContoCiccio = new ContoCorrente(Ciccio, 0, 50, 300000, "IT88A030901651000050570132");
            Generali.listaconti.Add(ContoPaolo);
            Conto_Online ContoLucaOnline = new Conto_Online(1000.00, Luca, 0, 50, 10000, "IT88A030901651000050570130", "CiccioCaputo", "Ciccio123");
            Generali.listaconti.Add(ContoLucaOnline);
            ContoCorrente contocercato = new ContoCorrente(personacreata, 0, 50, 0.0, "IT88A030801651000050570132");
            Console.WriteLine("Persone: \n--" + Paolo.Nome + " " + Paolo.Cognome + "\t Indirizzo: " + Paolo.Indirizzo + "\t Numero di telefono: " + Paolo.NumeroTel + "\t E-Mail: " + Paolo.EMail + "\t Data di nascita: " + Paolo.DataNascita);
            Console.WriteLine("--" + Luca.Nome + " " + Luca.Cognome + "\t Indirizzo: " + Luca.Indirizzo + "\t Numero di telefono: " + Luca.NumeroTel + "\t E-Mail: " + Luca.EMail + "\t Data di nascita: " + Luca.DataNascita);
            Console.WriteLine("--" + Ciccio.Nome + " " + Ciccio.Cognome + "\t Indirizzo: " + Ciccio.Indirizzo + "\t Numero di telefono: " + Ciccio.NumeroTel + "\t E-Mail: " + Ciccio.EMail + "\t Data di nascita: " + Ciccio.DataNascita);
            Console.WriteLine("\nBanca:\n--" + Generali.Nome + "\t" + Generali.Indirizzo);
            Console.WriteLine("\nConti correnti:\n--" + ContoPaolo.IntestatarioConto.Nome + " " + ContoPaolo.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoPaolo.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoPaolo.NMovimenti + "\t IBAN: " + ContoPaolo.Iban + "\t Saldo: " + ContoPaolo.Saldo);
            Console.WriteLine("--" + ContoCiccio.IntestatarioConto.Nome + " " + ContoCiccio.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoCiccio.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoCiccio.NMovimenti + "\t IBAN: " + ContoCiccio.Iban + "\t Saldo: " + ContoCiccio.Saldo);
            Console.WriteLine("\nConti correnti online:\n--" + ContoLucaOnline.IntestatarioConto.Nome + " " + ContoLucaOnline.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoLucaOnline.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoLucaOnline.NMovimenti + "\t IBAN: " + ContoLucaOnline.Iban + "\t Saldo: " + ContoLucaOnline.Saldo);
            Console.WriteLine("\nLista di concorrenti della banca Generali: ");
            for (int i = 0; i < Generali.listaconti.Count; i++)
            {
                Console.WriteLine("--" + Generali.listaconti[i].IntestatarioConto.Nome + " " + Generali.listaconti[i].IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + Generali.listaconti[i].MaxMovimenti + "\t Numero movimenti effettuati: " + Generali.listaconti[i].NMovimenti + "\t IBAN: " + Generali.listaconti[i].Iban + "\t Saldo: " + Generali.listaconti[i].Saldo);
            }
            Bonifico bonifico = new Bonifico(ContoCiccio, new DateTime(2020 / 05 / 22), 200, ContoPaolo);
            bonifico.CreaBonifico(ContoCiccio, new DateTime(2020 / 05 / 22), 200, ContoPaolo);
            Console.WriteLine("\n\n\nMovimenti: \n");
            Console.WriteLine("\nSi effettua un bonifico da 200 euro dal conto di Paolo Rossi al conto di Ciccio Caputo, i nuovi dati dei conti saranno:");
            Console.WriteLine("--" + ContoPaolo.IntestatarioConto.Nome + " " + ContoPaolo.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoPaolo.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoPaolo.NMovimenti + "\t IBAN: " + ContoPaolo.Iban + "\t Saldo: " + ContoPaolo.Saldo);
            Console.WriteLine("--" + ContoCiccio.IntestatarioConto.Nome + " " + ContoCiccio.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoCiccio.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoCiccio.NMovimenti + "\t IBAN: " + ContoCiccio.Iban + "\t Saldo: " + ContoCiccio.Saldo);
            Versamento versamento = new Versamento(new DateTime(2020, 05, 22, 22, 05, 20), 40, ContoLucaOnline);
            versamento.CreaVersamento();
            Console.WriteLine("\nLuca effettura un versamento da 40 euro sul proprio conto online, i nuovi dati del suo conto saranno:");
            Console.WriteLine("--" + ContoLucaOnline.IntestatarioConto.Nome + " " + ContoLucaOnline.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoLucaOnline.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoLucaOnline.NMovimenti + "\t IBAN: " + ContoLucaOnline.Iban + "\t Saldo: " + ContoLucaOnline.Saldo);
            Prelievo prelievo = new Prelievo(new DateTime(2020, 05, 22, 22, 05, 20), 200, ContoCiccio);
            prelievo.CreaPrelievo();
            Console.WriteLine("\nCicco Caputo preleva i soldi ricevuti dal bonifico effettuato da Paolo, i dati del suo conto saranno aggiornati a:");
            Console.WriteLine("--" + ContoCiccio.IntestatarioConto.Nome + " " + ContoCiccio.IntestatarioConto.Cognome + "\t Numero movimenti gratuiti: " + ContoCiccio.MaxMovimenti + "\t Numero movimenti effettuati: " + ContoCiccio.NMovimenti + "\t IBAN: " + ContoCiccio.Iban + "\t Saldo: " + ContoCiccio.Saldo);
            int scelta1 = 1;
            var dictionary = new Dictionary<int, List<Movimento>>();
            int altro = 0;
            List<int> scelte = new List<int>();
            do
            {
                do
                {
                    Console.WriteLine("\nInserire l'opzione richiesta \n 1- aggiungere intestatario \n 2- aggiungere banca \n 3- aggiungere conto \n 4- aggiungere conto online \n 5- aggiungere movimento \n");
                    scelta1 = Convert.ToInt32(Console.ReadLine());
                } while (scelta1 > 6 || scelta1 < 1);
                
                bool risultato = false;
                bool sovrascrivi = false;
                int sceltasovrascrivi = 0;
                if (scelta1 == 1)
                {
                    for (int i = 0; i < scelte.Count; i++)
                    {
                        if (scelte[i] == 1)
                        {
                            sovrascrivi = true;
                        }
                    }
                    if (sovrascrivi == true)
                    {
                        Console.WriteLine("E' stato creato il numero massimo di intestatari, sovrascrivere il precedente?\n1- si\n2- no");
                        sceltasovrascrivi = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                    string nomepersona = "";
                        string cognomepersona = "";
                        string emailpersona = "";
                        string numeropersona = "";
                        string indirizzopersona = "";
                        int annonascitapersona = 0;
                        int mesenascitapersona = 0;
                        int giornonascitapersona = 0;
                        Console.WriteLine("\nInserisci il nome della persona:");
                        nomepersona = Console.ReadLine();
                        personacreata.Nome = nomepersona;
                        Console.WriteLine("Inserisci il cognome della persona:");
                        cognomepersona = Console.ReadLine();
                        personacreata.Cognome = cognomepersona;
                        Console.WriteLine("Inserisci l'idirizzo della persona:");
                        indirizzopersona = Console.ReadLine();
                        personacreata.Indirizzo = indirizzopersona;
                        Console.WriteLine("Inserisci il numero di telefono della persona:");
                        numeropersona = Console.ReadLine();
                        personacreata.NumeroTel = numeropersona;
                        Console.WriteLine("Inserisci l' e-mail della persona:");
                        emailpersona = Console.ReadLine();
                        personacreata.EMail = emailpersona;
                        Console.WriteLine("Inserisci l'anno di nascita della persona:");
                        annonascitapersona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il mese di nascita della persona:");
                        mesenascitapersona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il giorno di nascita della persona:");
                        giornonascitapersona = Convert.ToInt32(Console.ReadLine());
                        personacreata.DataNascita = new DateTime(annonascitapersona / mesenascitapersona / giornonascitapersona);
                        Console.WriteLine("\nPersona creata con successo.");
                        scelte.Add(scelta1);
                    }
                    if (sceltasovrascrivi == 1)
                    {
                        string nomepersona = "";
                        string cognomepersona = "";
                        string emailpersona = "";
                        string numeropersona = "";
                        string indirizzopersona = "";
                        int annonascitapersona = 0;
                        int mesenascitapersona = 0;
                        int giornonascitapersona = 0;
                        Console.WriteLine("\nInserisci il nome della persona:");
                        nomepersona = Console.ReadLine();
                        personacreata.Nome = nomepersona;
                        Console.WriteLine("Inserisci il cognome della persona:");
                        cognomepersona = Console.ReadLine();
                        personacreata.Cognome = cognomepersona;
                        Console.WriteLine("Inserisci l'idirizzo della persona:");
                        indirizzopersona = Console.ReadLine();
                        personacreata.Indirizzo = indirizzopersona;
                        Console.WriteLine("Inserisci il numero di telefono della persona:");
                        numeropersona = Console.ReadLine();
                        personacreata.NumeroTel = numeropersona;
                        Console.WriteLine("Inserisci l' e-mail della persona:");
                        emailpersona = Console.ReadLine();
                        personacreata.EMail = emailpersona;
                        Console.WriteLine("Inserisci l'anno di nascita della persona:");
                        annonascitapersona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il mese di nascita della persona:");
                        mesenascitapersona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il giorno di nascita della persona:");
                        giornonascitapersona = Convert.ToInt32(Console.ReadLine());
                        personacreata.DataNascita = new DateTime(annonascitapersona / mesenascitapersona / giornonascitapersona);
                        Console.WriteLine("\nPersona creata con successo.");
                        scelte.Add(scelta1);
                    }
                    if (sceltasovrascrivi == 2)
                    {
                        Console.WriteLine("Operazione anullata");
                    }
                    do
                    {
                        Console.WriteLine("\n Aggiungere altro?\n1- si\n2- no");
                        altro = Convert.ToInt32(Console.ReadLine());
                    } while (altro < 1 || altro > 2);
                }
                string nomericerca = "";
                string cognomericerca = "";
                Persona ricerca = null;
                string nomebanca = "";
                string indirizzobanca = "";
                if (scelta1 == 2)
                {
                    for (int i = 0; i < scelte.Count; i++)
                    {
                        if (scelte[i] == 2)
                        {
                            sovrascrivi = true;
                        }
                    }
                    if (sovrascrivi == true)
                    {
                        Console.WriteLine("E' stato creato il numero massimo delle banche, sovrascrivere la precedente?\n1- si\n2- no");
                        sceltasovrascrivi = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nInserisci il nome della banca:");
                        nomebanca = Console.ReadLine();
                        Console.WriteLine("Inserisci l'indirizzo della banca:");
                        indirizzobanca = Console.ReadLine();
                        Banca bancacreata = new Banca(nomebanca, indirizzobanca);
                        Console.WriteLine("\nBanca creata con successo");
                        scelte.Add(scelta1);
                    }
                    if (sceltasovrascrivi == 1)
                    {
                        Console.WriteLine("\nInserisci il nome della banca:");
                        nomebanca = Console.ReadLine();
                        Console.WriteLine("Inserisci l'indirizzo della banca:");
                        indirizzobanca = Console.ReadLine();
                        Banca bancacreata = new Banca(nomebanca, indirizzobanca);
                        Console.WriteLine("\nBanca creata con successo");
                        scelte.Add(scelta1);
                    }
                    if (sceltasovrascrivi == 2)
                    {
                        Console.WriteLine("Operazione anullata");
                    }
                    do
                    {
                        Console.WriteLine("\n Aggiungere altro?\n1- si\n2- no");
                        altro = Convert.ToInt32(Console.ReadLine());
                    } while (altro < 1 || altro > 2);
                }
                if (scelta1 == 3)
                {
                    Console.WriteLine("\nInserire il nome dell'intestatario che si vuole trovare:");
                    nomericerca = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome dell'intestatario:");
                    cognomericerca = Console.ReadLine();
                    if (Paolo.Nome == nomericerca)
                    {
                        if (Paolo.Cognome == cognomericerca)
                        {
                            ricerca = Paolo;
                            risultato = true;
                            Console.WriteLine("\nLa persona è stata trovata con successo");
                        }
                    }
                    if (Luca.Nome == nomericerca)
                    {
                        if (Luca.Cognome == cognomericerca)
                        {
                            ricerca = Luca;
                            risultato = true;
                            Console.WriteLine("\nPLa persona è stata trovata con successo");
                        }
                    }
                    if (Ciccio.Nome == nomericerca)
                    {
                        if (Ciccio.Cognome == cognomericerca)
                        {
                            ricerca = Ciccio;
                            risultato = true;
                            Console.WriteLine("\nLa persona è stata trovata con successo");
                        }
                    }
                    if (personacreata.Nome == nomericerca)
                    {
                        if (personacreata.Cognome == cognomericerca)
                        {
                            ricerca = personacreata;
                            risultato = true;
                            Console.WriteLine("\nPersona trovata nel database");
                        }
                    }
                    if (risultato == false)
                    {
                        Console.WriteLine("\nLa persona non è stata trovata.");
                    }
                    if (risultato == true)
                    {
                        contocreato.IntestatarioConto = ricerca;
                        Console.WriteLine("\nConto creato con successo.");
                        scelte.Add(scelta1);
                    }
                    do
                    {
                        Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                        altro = Convert.ToInt32(Console.ReadLine());
                    } while (altro < 1 || altro > 2);
                }
                string usernameutente = "";
                string passwordutente = "";
                if (scelta1 == 4)
                {
                    Console.WriteLine("\nInserire il nome dell'intestatario del conto:");
                    nomericerca = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome dell'intestatario del conto:");
                    cognomericerca = Console.ReadLine();
                    if (Paolo.Nome == nomericerca)
                    {
                        if (Paolo.Cognome == cognomericerca)
                        {
                            ricerca = Paolo;
                            risultato = true;
                            Console.WriteLine("\nPersona trovata con successo");
                        }
                    }
                    if (Luca.Nome == nomericerca)
                    {
                        if (Luca.Cognome == cognomericerca)
                        {
                            ricerca = Luca;
                            risultato = true;
                            Console.WriteLine("\nPersona trovata con successo");
                        }
                    }
                    if (Ciccio.Nome == nomericerca)
                    {
                        if (Ciccio.Cognome == cognomericerca)
                        {
                            ricerca = Ciccio;
                            risultato = true;
                            Console.WriteLine("\nPersona trovata con successo");
                        }
                    }
                    if (personacreata.Nome == nomericerca)
                    {
                        if (personacreata.Cognome == cognomericerca)
                        {
                            ricerca = personacreata;
                            risultato = true;
                            Console.WriteLine("\nPersona trovata con successo");
                        }
                    }
                    if (risultato == false)
                    {
                        Console.WriteLine("\nPersona non presente.");
                        do
                        {
                            Console.WriteLine("\nSi vuole usare un'altra funzione?\n1- si\n2- no");
                            altro = Convert.ToInt32(Console.ReadLine());
                        } while (altro < 1 || altro > 2);
                    }
                    if (risultato== true)
                    {
                        Console.WriteLine("\nInserisci l'username dell'utente:");
                        usernameutente = Console.ReadLine();
                        Console.WriteLine("Inserisci la password dell'utente:");
                        passwordutente = Console.ReadLine();
                        ContoCreatoOnline.IntestatarioConto = ricerca;
                        ContoCreatoOnline.Username = usernameutente;
                        ContoCreatoOnline.Password = passwordutente;
                        Console.WriteLine("\nConto creato con successo.");
                        scelte.Add(scelta1);
                        do
                        {
                            Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                            altro = Convert.ToInt32(Console.ReadLine());
                        } while (altro < 1 || altro > 2);
                    }
                }
                double importo = 0;
                if (scelta1 == 5)
                {
                    int Contatoremov = 0;
                    int sceltamov = 0;
                    do
                    {
                        if (Contatoremov >= 1)
                        {
                            Console.WriteLine("Inserisci un numero compreso tra 1 e 3");
                        }
                        Console.WriteLine("\nQuale movimento si vuole eseguire? \n 1-versamento \n 2-prelievo \n 3-bonifico");
                        sceltamov = Convert.ToInt32(Console.ReadLine());
                        Contatoremov++;
                    } while (sceltamov < 1 || sceltamov > 3);
                    if (sceltamov == 1)
                    {
                        Console.WriteLine("\nVERSAMENTO:\nnome intestatario conto:");
                        nomericerca = Console.ReadLine();
                        Console.WriteLine("cognome intestatario conto:");
                        cognomericerca = Console.ReadLine();
                        if (ContoPaolo.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoPaolo.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoPaolo;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCiccio.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCiccio.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCiccio;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoLucaOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoLucaOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoLucaOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == nomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = contocreato;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == nomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = contocreato;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCreatoOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCreatoOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCreatoOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (risultato == false)
                        {
                            Console.WriteLine("\nConto non trovato.");
                            do
                            {
                                Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                        if (risultato == true)
                        {
                            Console.WriteLine("inserire l'importo:");
                            importo = Convert.ToDouble(Console.ReadLine());
                            contocercato.Saldo = contocercato.Saldo + importo;
                            Console.WriteLine("Versamento effettuato con successo.");
                            scelte.Add(scelta1);
                            do
                            {
                                Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                    }
                    if (sceltamov == 2)
                    {
                        Console.WriteLine("\nPRELIEVO:\nnome intestatario conto:");
                        nomericerca = Console.ReadLine();
                        Console.WriteLine("cognome intestatario conto:");
                        cognomericerca = Console.ReadLine();
                        if (ContoPaolo.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoPaolo.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoPaolo;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCiccio.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCiccio.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCiccio;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoLucaOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoLucaOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoLucaOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == nomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = contocreato;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == nomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = contocreato;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCreatoOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCreatoOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCreatoOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (risultato == false)
                        {
                            Console.WriteLine("\nConto non trovato.");
                            do
                            {
                                Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                        if (risultato == true)
                        {
                            contocercato.Saldo = contocercato.Saldo - importo;
                            Console.WriteLine("Prelievo effettuato con successo.");
                            scelte.Add(scelta1);
                            do
                            {
                                Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                    }
                    if (sceltamov == 3)
                    {
                        Console.WriteLine("\nBONIFICO:\nNome intestatario mittende:");
                        nomericerca = Console.ReadLine();
                        Console.WriteLine("cognome intestatario mittente:");
                        cognomericerca = Console.ReadLine();
                        if (ContoPaolo.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoPaolo.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoPaolo;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCiccio.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCiccio.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCiccio;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoLucaOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoLucaOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoLucaOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == cognomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = contocreato;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (ContoCreatoOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCreatoOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                risultato = true;
                                contocercato = ContoCreatoOnline;
                                Console.WriteLine("\nConto trovato con successo.");
                            }
                        }
                        if (risultato == false)
                        {
                            Console.WriteLine("\nConto non trovato.");
                            do
                            {
                                Console.WriteLine("\nSi vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                        if (risultato == true)
                        {
                            Console.WriteLine("inserire l'importo:");
                            importo = Convert.ToDouble(Console.ReadLine());
                            contocercato.Saldo = contocercato.Saldo - importo;
                            risultato = false;
                        }
                        bool ripetizione = false;
                        Console.WriteLine("\nNome dell'intestatario destinatario:");
                        nomericerca = Console.ReadLine();
                        Console.WriteLine("Cognome dell'intestatario destinatario:");
                        cognomericerca = Console.ReadLine();
                        if (ContoPaolo.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoPaolo.IntestatarioConto.Cognome == cognomericerca)
                            {
                                if (ContoPaolo == contocercato)
                                {
                                    risultato = false;
                                    ripetizione = true;
                                    Console.WriteLine("Il conto selezionato è uguale al precente, bonifico annullato.");
                                    do
                                    {
                                        Console.WriteLine("\nSi vuole usare un'altra funzione?\n1- si\n2- no");
                                        altro = Convert.ToInt32(Console.ReadLine());
                                    } while (altro < 1 || altro > 2);
                                }
                                else
                                {
                                    risultato = true;
                                    contocercato = ContoPaolo;
                                    Console.WriteLine("\nConto trovato con successo.");
                                }
                            }
                        }
                        if (ContoCiccio.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCiccio.IntestatarioConto.Cognome == cognomericerca)
                            {
                                if (ContoCiccio == contocercato)
                                {
                                    risultato = false;
                                    ripetizione = true;
                                    Console.WriteLine("Il conto selezionato è uguale al precente, bonifico annullato.");
                                    do
                                    {
                                        Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                        altro = Convert.ToInt32(Console.ReadLine());
                                    } while (altro < 1 || altro > 2);
                                }
                                else
                                {
                                    risultato = true;
                                    contocercato = ContoCiccio;
                                    Console.WriteLine("\nConto trovato con successo.");
                                }
                            }
                        }
                        if (ContoLucaOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoLucaOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                if (ContoLucaOnline == contocercato)
                                {
                                    risultato = false;
                                    ripetizione = true;
                                    Console.WriteLine("Il conto selezionato è uguale al precente, bonifico annullato.");
                                    do
                                    {
                                        Console.WriteLine("\nSi vuole usare un'altra funzione?\n1- si\n2- no");
                                        altro = Convert.ToInt32(Console.ReadLine());
                                    } while (altro < 1 || altro > 2);
                                }
                                else
                                {
                                    risultato = true;
                                    contocercato = ContoLucaOnline;
                                    Console.WriteLine("\nConto trovato con successo.");
                                }
                            }
                        }
                        if (contocreato.IntestatarioConto.Nome == nomericerca)
                        {
                            if (contocreato.IntestatarioConto.Cognome == cognomericerca)
                            {
                                if (contocreato == contocercato)
                                {
                                    risultato = false; ripetizione = true;
                                    Console.WriteLine("Il conto selezionato è uguale al precente, bonifico annullato.");
                                    do
                                    {
                                        Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                        altro = Convert.ToInt32(Console.ReadLine());
                                    } while (altro < 1 || altro > 2);
                                }
                                else
                                {
                                    risultato = true;
                                    contocercato = contocreato;
                                    Console.WriteLine("\nConto trovato con successo.");
                                }
                            }
                        }
                        if (ContoCreatoOnline.IntestatarioConto.Nome == nomericerca)
                        {
                            if (ContoCreatoOnline.IntestatarioConto.Cognome == cognomericerca)
                            {
                                if (ContoCreatoOnline == contocercato)
                                {
                                    risultato = false;
                                    ripetizione = true;
                                    Console.WriteLine("Il conto selezionato è uguale al precente, bonifico annullato.");
                                    do
                                    {
                                        Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                        altro = Convert.ToInt32(Console.ReadLine());
                                    } while (altro < 1 || altro > 2);
                                }
                                else
                                {
                                    risultato = true;
                                    contocercato = ContoCreatoOnline;
                                    Console.WriteLine("\nConto trovato con successo.");
                                }
                            }
                        }
                        if (risultato == false && ripetizione == false)
                        {
                            Console.WriteLine("\nConto non trovato nel database.\nOperazione annullata.");
                            do
                            {
                                Console.WriteLine("\n Si vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                        if (risultato == true)
                        {
                            contocercato.Saldo = contocercato.Saldo - importo;
                            Console.WriteLine("Bonifico effettuato con successo.");
                            scelte.Add(scelta1);
                            do
                            {
                                Console.WriteLine("\nSi vuole usare un'altra funzione?\n1- si\n2- no");
                                altro = Convert.ToInt32(Console.ReadLine());
                            } while (altro < 1 || altro > 2);
                        }
                    }
        }
                } while (altro == 1);
            Console.ReadLine();
        }
    }
}
