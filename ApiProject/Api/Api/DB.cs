using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api
{
    public class DB
    {
       
        public static List<FeedBack> listFeedBacks = new List<FeedBack>()
        {
            new FeedBack(){name="אורטל",feedBack="לא סתם חזרתי אליך פעם שניה, המקצועיות ניכרת בכל תנועה ,מהעיטופים העדינים וההצלחה להריץ את הצילומים במהירות בלי שהילד יקום. המחמאות שקיבלתי על התמונות היו מטורפות זה המתנה המושלמת ללידה! !הרבה הצלחה",numberLike=5,city="אלעד",date=new DateTime(2018,5,1)},
            new FeedBack(){name="יעל",feedBack=$" אילה מהממת -- רואים שאת לגמרי עושה את מה שאת הכי אוהבת! בתור לקוחה חוזרת-אחרי כל לידה יש את הטלפון הקבוע אליך    🙂 מה שקנה אותי בך זה הרוגע בזמן הצילומים ,השקט, המהירות, ובנוסף לזה לא שוכחת לעשות הכל ברגישות ועם המון אהבה לעולל הקטן!! את מנציחה רגעים שמהר מאד יעלמו ועושה מהם יצירת אומנות שאי אפשר להפסיק להסתכל--- תודה לך על מתנת לידה שווה במיוחד 🙂",numberLike=3,city="ירושלים",date=new DateTime(2018,5,1)},
            new FeedBack(){name="מיכל",feedBack="אילה, חווית הצילום איתך זו חוויה מומלצת לכל יולדת!! פינוק מושלם בעיניי! את ככ מקצועית ועדינה עם התינוק שזה פשוט מטורף! נהניתי לראות מהצד איך הכל נעשה ככ ברוגע ובעדינות בתנאים הכי בסיסיים שיש, בלי סטודיו מאובזר, כשכל האיבזור מגיע איתך במזוודה והיחס שלך גם לבן הגדול שלי- מדהימה!!! האהבה שלך למקצוע ולתינוקות מורגש בענק! וכמובן שעל התוצאות אין צורך לדבר בתור צלמת שמבינה כמה מקצועיות עומדת מאחורי כל פרט ופרט התפעלתי מאד מהמקצועיות, התאורה, התנוחות והעיבוד - פשוט ליגה!!",numberLike=6,city= "ביתר",date=new DateTime(2018,5,1)},
            new FeedBack(){name="רחל",feedBack = "אילה יקרה, קיבלנו את התמונות וזה נראה וואוו👏מעבר לציפיות שלנו..אין לנו מילים להודות לך על החוויה המדהימה שעברנו יחד, זכינו לחווית צילום סופר מקצועי ויחס חם ואנושי, יש בך ככ הרבה רגישות, הבנה וכל כך הרבה סבלנות! תודה רבה על בחירה מושלמת ואין לי ספק שעוד ניפגש. תודה רבה!!" ,city="המרכז",numberLike=2,date=new DateTime(2018,5,1)},
            new FeedBack(){name="ריקי",feedBack="אילה היא סוג של קסם. והדרך שלה לתוצרים המהפנטים- מהפנטת לא פחות. האומנות הנונשלנטית, הסבלנות והרכות, יחד עם יד אמונה ויציבה, וכמובן היחס המלכותי לבייבי (ולאימו) יצרו חוויה בלתי נשכחת, ותמונות- מהאגדות!!",city="בני ברק",numberLike=3,date=new DateTime(2018,5,1)},
            new FeedBack(){name="תהילה",feedBack="לצלם אצלך איילה זה לא רק התמונות.את אלופה ביחס לתינוקות. הרוגע שלך, החיוך, המאור פנים, הם נדירים!! הפקדתי את התינוקת שלי בידיים שלך בשלווה גמורה. ידעתי בוודאות שהיא בידיים טובות. ואז הגיעו התמונות... וואוווו אין מילים שיתארו. המקצועיות, הדיוק, הטוהר והיופי שרואים בתמונות... אין להם מתחרים!! אז כמובן שחזרנו אליך לצילומי חצי שנה ואז שוב לצילומי סמאשקייק בגיל שנה. התמונות מלוות אותנו. המתיקות של הגיל שהשתמרה לה בתמונה בזכותך - זה נכס!! ממליצה עליך לכל מי ששואל - כי את לגמרי אחת ויחידה!!",city="ירושלים",numberLike=2,date=new DateTime(2018,5,1)},
            new FeedBack(){name="שרה",feedBack="חיפשתי צלמת ניו בורן אלופה והגעתי לאילה (אגב אני צלמת אז חיפשתי מישהי טובה באמת) לכל אורך הצילומים נהנתי מהעדינות והרוך ומהגישה לתינוקת בסבלנות ובאהבה היה מאוד מאוד רגוע ושליו כל דקה נהנתי ונשבתי בקסם הזה של התמונות ממיסות זה היה מהפנט ואילה במקצועיות ובסבלנות הוציאה לנו אלבום מטורף פשוט כל תמונה גלויה ממליצה בחום מחכה כבר לפעם הבאה",city="ירושלים",numberLike=2,date=new DateTime(2018,5,1)},

        };



        public static List<Gallery> ListGalleries = new List<Gallery>()
        {
            new Gallery()
            {
                            Category="בנים",Description="צילומי ניו בורן בנים נערכים או לפני הברית או 3 ימים לאחר הברית.  נעטוף בהמון אביזרים מיוחדים ועיטופים שנסרגו במיוחד בשביל הבייבי שלך "
                           ,Image=@"assets\images\homepageimg\img4.jpg" ,
                            Images=new string[]
                            {
                                @"assets\images\sons\son1.jpg" ,@"assets\images\sons\son2.jpg" ,@"assets\images\sons\son3.jpg" ,
                                @"assets\images\sons\son4.jpg" ,@"assets\images\sons\son5.jpg" ,@"assets\images\sons\son6.jpg" ,
                                @"assets\images\sons\son7.jpg" ,@"assets\images\sons\son8.jpg" ,@"assets\images\sons\son9.jpg" ,
                                @"assets\images\sons\son10.jpg" ,@"assets\images\sons\son11.jpg" ,@"assets\images\sons\son12.jpg" ,
                                @"assets\images\sons\son13.jpg" ,@"assets\images\sons\son14.jpg" ,@"assets\images\sons\son15.jpg" ,
                                @"assets\images\sons\son16.jpg" ,@"assets\images\sons\son17.jpg" ,@"assets\images\sons\son18.jpg" ,
                                @"assets\images\sons\son19.jpg" ,@"assets\images\sons\son20.jpg" ,@"assets\images\sons\son21.jpg" ,
                                @"assets\images\sons\son22.jpg" ,@"assets\images\sons\son23.jpg" ,@"assets\images\sons\son24.jpg" ,
                                @"assets\images\sons\son25.jpg" ,@"assets\images\sons\son26.jpg" ,@"assets\images\sons\son27.jpg" ,
                                @"assets\images\sons\son28.jpg" ,@"assets\images\sons\son29.jpg" ,@"assets\images\sons\son30.jpg" ,
                                @"assets\images\sons\son31.jpg" ,@"assets\images\sons\son32.jpg" ,
                           }
             },


            new Gallery()
            { 
                 Category="בנות",Description="צילומי ניו בורן בנות הם חוויה מרתקת . אין סוף לאביזרים ולסרטים שאפשר לעטוף בהם את הנסיכה הקטנה לתוצאה מלאכית ומהפנטת"
                 ,Image=@"assets\images\homepageimg\img10.jpg",
                 Images=new string[]
                            {
                                @"assets\images\girls\girls1.jpg" ,@"assets\images\girls\girls2.jpg" ,@"assets\images\girls\girls3.jpg" ,
                                @"assets\images\girls\girls4.jpg" ,@"assets\images\girls\girls5.jpg" ,@"assets\images\girls\girls6.jpg" ,
                                @"assets\images\girls\girls7.jpg" ,@"assets\images\girls\girls8.jpg" ,@"assets\images\girls\girls9.jpg" ,
                                @"assets\images\girls\girls10.jpg" ,@"assets\images\girls\girls11.jpg" ,@"assets\images\girls\girls12.jpg" ,
                                @"assets\images\girls\girls13.jpg" ,@"assets\images\girls\girls14.jpg" ,@"assets\images\girls\girls15.jpg" ,
                                @"assets\images\girls\girls16.jpg" ,@"assets\images\girls\girls17.jpg" ,@"assets\images\girls\girls18.jpg" ,
                                @"assets\images\girls\girls19.jpg" ,@"assets\images\girls\girls20.jpg" ,@"assets\images\girls\girls21.jpg" ,
                                @"assets\images\girls\girls22.jpg" ,@"assets\images\girls\girls23.jpg" ,@"assets\images\girls\girls24.jpg" ,
                                @"assets\images\girls\girls25.jpg" ,@"assets\images\girls\girls26.jpg" ,@"assets\images\girls\girls27.jpg" ,
                                @"assets\images\girls\girls28.jpg" ,@"assets\images\girls\girls29.jpg" ,@"assets\images\girls\girls30.jpg" ,
                                @"assets\images\girls\girls31.jpg" ,@"assets\images\girls\girls32.jpg" ,@"assets\images\girls\girls33.jpg" ,
                                @"assets\images\girls\girls34.jpg" ,@"assets\images\girls\girls35.jpg"
                           }
            },
            new Gallery()
            {
                Category="תאומים",Description="צילומי תאומים זהו יופי כפול הרכות והחיבור שלהם יחד זה משהו מיוחד, אני אוהבת לשחק עם שילובי צבעים ותנוחות מעניינות להרמוניה מושלמת"
                ,Image=@"assets\images\homepageimg\twins1.jpg",
                Images=new string[]
                            {
                                @"assets\images\twins\twins1.jpg" ,@"assets\images\twins\twins2.jpg" ,@"assets\images\twins\twins3.jpg" ,
                                @"assets\images\twins\twins4.jpg" ,@"assets\images\twins\twins5.jpg" ,@"assets\images\twins\twins6.jpg" ,
                                @"assets\images\twins\twins7.jpg" ,@"assets\images\twins\twins8.jpg" ,@"assets\images\twins\twins9.jpg" ,
                                @"assets\images\twins\twins10.jpg" ,@"assets\images\twins\twins11.jpg" ,@"assets\images\twins\twins12.jpg" ,
                                @"assets\images\twins\twins13.jpg" ,@"assets\images\twins\twins14.jpg" ,@"assets\images\twins\twins15.jpg" ,
                                @"assets\images\twins\twins16.jpg" ,@"assets\images\twins\twins17.jpg" ,@"assets\images\twins\twins18.jpg" ,
                                
                           }
            },


            new Gallery()
            {
                          Category="משפחה",Description="בייבי חדש נוסף למשפחה?חגיגה. זה הזמן לשמר את רגעי ההכרות החדשים של האחים וההורים בתמונות רכות וטהורות . ממש כמו הבייביס האלה",
                          Image=@"assets\images\homepageimg\family2.jpg",
                          Images=new string[]
                          { 
                                @"assets\images\family\1.jpg" ,@"assets\images\family\2.jpg" ,@"assets\images\family\3.jpg" ,
                                @"assets\images\family\4.jpg" ,@"assets\images\family\5.jpg" ,@"assets\images\family\6.jpg" ,
                                @"assets\images\family\7.jpg" ,@"assets\images\family\8.jpg" ,@"assets\images\family\9.jpg" ,
                                @"assets\images\family\10.jpg" ,@"assets\images\family\11.jpg" ,@"assets\images\family\12.jpg" ,
                                @"assets\images\family\13.jpg" ,@"assets\images\family\14.jpg" ,@"assets\images\family\15.jpg" ,
                                @"assets\images\family\16.jpg" ,@"assets\images\family\17.jpg" ,@"assets\images\family\18.jpg" ,
                                @"assets\images\family\19.jpg" ,@"assets\images\family\20.jpg" ,@"assets\images\family\21.jpg" ,
                                @"assets\images\family\22.jpg" ,@"assets\images\family\23.jpg" ,@"assets\images\family\24.jpg" ,
                                @"assets\images\family\25.jpg" ,@"assets\images\family\26.jpg" ,@"assets\images\family\27.jpg" ,
                                @"assets\images\family\28.jpg" ,@"assets\images\family\29.jpg" ,@"assets\images\family\30.jpg" ,
                                @"assets\images\family\31.jpg" ,@"assets\images\family\32.jpg" ,
                               
                          }
             }


        };
    }
}