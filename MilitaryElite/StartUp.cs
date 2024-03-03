using System.ComponentModel.DataAnnotations;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Soldier> theList = new List<Soldier>();
            List<Private> privateList = new List<Private>();
            List<Spy> spyList = new List<Spy>();
            string input;
            while((input = Console.ReadLine()) != "End")
            
            {
                string[] info = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (info[0])
                {
                    case "Private":
                        Private unit = new Private(info[1], info[2], info[3], decimal.Parse(info[4]));
                        privateList.Add(unit);
                        theList.Add(unit);

                        break;
                    case "Commando":
                        if (info[5] != "Airforces" && info[5] != "Marines")
                        {
                            continue;
                        }
                        Commando unit1 = new Commando(info[1], info[2], info[3], decimal.Parse(info[4]), info[5]);

                        if (info.Length > 6 && info.Length % 2 == 0)
                        {


                            for (int i = 6 ; i < info.Length; i+=2)
                            {
                                if (info[i+1] == "inProgress" || info[i + 1] == "Finished")
                                {
                                    
                                    Mission mission = new Mission(info[i], info[i + 1]);
                                    
                                    unit1.Missions.Add(mission);
                                }
                            }
                            
                        }
                        theList.Add(unit1);

                        break;

                    case "Engineer":
                        if (info[5] != "Airforces" && info[5] != "Marines")
                        {
                            continue;
                        }
                        Engineer unit2 = new Engineer(info[1], info[2], info[3], decimal.Parse(info[4]), info[5]);

                        if (info.Length > 6)
                        {


                            for (int i = 6; i < info.Length; i += 2)
                            {

                                Repair rep = new Repair(info[i], int.Parse(info[i + 1]));
                                unit2.Repairs.Add(rep);

                            }

                        }

                        theList.Add(unit2);
                        break;

                    case "LieutenantGeneral":

                        LieutenantGeneral unit3 = new(info[1], info[2], info[3], decimal.Parse(info[4]));

                        if(info.Length > 5)
                        {
                            for (int i = 5; i < info.Length; i++)
                            {
                                string soldierId = info[i];
                                foreach(var item in privateList)
                                {
                                    if(item.Id == soldierId)
                                    { 
                                        unit3.Privates.Add(item);
                                    }
                                }

                            }
                        }
                        theList.Add(unit3);
                        break;

                    case "Spy":

                        Spy spy = new(info[1], info[2], info[3], int.Parse(info[4]));
                        theList.Add(spy);
                        break;




                }



            }
            
            foreach(var item in theList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}