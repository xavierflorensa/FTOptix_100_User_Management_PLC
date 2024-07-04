#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.RAEtherNetIP;
using FTOptix.NativeUI;
using FTOptix.NetLogic;
using FTOptix.CoreBase;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
#endregion

public class DesignTimeNetLogic2 : BaseNetLogic
{
    [ExportMethod]
    public void Method1()
    {
        // Insert code to be executed by the method
                // Insert code to be executed by the method
        Folder userFolder = Project.Current.Get<Folder>("Security/Users");
    if (userFolder == null) {
        Log.Error("CreateNewUser", "Cannot find Users folder");
        return;
    } 
    /*else if (string.IsNullOrEmpty(groupName)) {
        Log.Error("CreateNewGroup", "Cannot create group with empty name");
        return;
    } else if (userFolder.Get<Group>(groupName) != null) {
        Log.Error("CreateNewGroup", "Group already exists!");
        return;
    }
    */
    // Create a new user
    var newUser0 = InformationModel.Make<User>("Xavier0");
    // Add the user to the folder
    userFolder.Add(newUser0);
    var newUser1 = InformationModel.Make<User>("Xavier1");
    userFolder.Add(newUser1);
    var newUser2 = InformationModel.Make<User>("Xavier2");
    userFolder.Add(newUser2);
    var newUser3 = InformationModel.Make<User>("Xavier3");
    userFolder.Add(newUser3);
    var newUser4 = InformationModel.Make<User>("Xavier4");
    userFolder.Add(newUser4);
    var newUser5 = InformationModel.Make<User>("Xavier5");
    userFolder.Add(newUser5);
    var newUser6 = InformationModel.Make<User>("Xavier6");
    userFolder.Add(newUser6);
    var newUser7 = InformationModel.Make<User>("Xavier7");
    userFolder.Add(newUser7);
    var newUser8 = InformationModel.Make<User>("Xavier8");
    userFolder.Add(newUser8);
    var newUser9 = InformationModel.Make<User>("Xavier9");
    userFolder.Add(newUser9);
    var newUser10 = InformationModel.Make<User>("Xavier10");
    userFolder.Add(newUser10);

    var newUser11 = InformationModel.Make<User>("Xavier11");
    userFolder.Add(newUser11);
    var newUser12 = InformationModel.Make<User>("Xavier12");
    userFolder.Add(newUser12);
    var newUser13 = InformationModel.Make<User>("Xavier13");
    userFolder.Add(newUser13);
    var newUser14 = InformationModel.Make<User>("Xavier14");
    userFolder.Add(newUser14);
    var newUser15 = InformationModel.Make<User>("Xavier15");
    userFolder.Add(newUser15);
    var newUser16 = InformationModel.Make<User>("Xavier16");
    userFolder.Add(newUser16);
    var newUser17 = InformationModel.Make<User>("Xavier17");
    userFolder.Add(newUser17);
    var newUser18 = InformationModel.Make<User>("Xavier18");
    userFolder.Add(newUser18);
    var newUser19 = InformationModel.Make<User>("Xavier19");
    userFolder.Add(newUser19);
    var newUser20 = InformationModel.Make<User>("Xavier20");
    userFolder.Add(newUser20);

    var newUser21 = InformationModel.Make<User>("Xavier21");
    userFolder.Add(newUser21);
    var newUser22 = InformationModel.Make<User>("Xavier22");
    userFolder.Add(newUser22);
    var newUser23 = InformationModel.Make<User>("Xavier23");
    userFolder.Add(newUser23);
    var newUser24 = InformationModel.Make<User>("Xavier24");
    userFolder.Add(newUser24);
    var newUser25 = InformationModel.Make<User>("Xavier25");
    userFolder.Add(newUser25);
    var newUser26 = InformationModel.Make<User>("Xavier26");
    userFolder.Add(newUser26);
    var newUser27 = InformationModel.Make<User>("Xavier27");
    userFolder.Add(newUser27);
    var newUser28 = InformationModel.Make<User>("Xavier28");
    userFolder.Add(newUser28);
    var newUser29 = InformationModel.Make<User>("Xavier29");
    userFolder.Add(newUser29);
    var newUser30 = InformationModel.Make<User>("Xavier30");
    userFolder.Add(newUser30);

    var newUser31 = InformationModel.Make<User>("Xavier31");
    userFolder.Add(newUser31);
    var newUser32 = InformationModel.Make<User>("Xavier32");
    userFolder.Add(newUser32);
    var newUser33 = InformationModel.Make<User>("Xavier33");
    userFolder.Add(newUser33);
    var newUser34 = InformationModel.Make<User>("Xavier34");
    userFolder.Add(newUser34);
    var newUser35 = InformationModel.Make<User>("Xavier35");
    userFolder.Add(newUser35);
    var newUser36 = InformationModel.Make<User>("Xavier36");
    userFolder.Add(newUser36);
    var newUser37 = InformationModel.Make<User>("Xavier37");
    userFolder.Add(newUser37);
    var newUser38 = InformationModel.Make<User>("Xavier38");
    userFolder.Add(newUser38);
    var newUser39 = InformationModel.Make<User>("Xavier39");
    userFolder.Add(newUser39);
    var newUser40 = InformationModel.Make<User>("Xavier40");
    userFolder.Add(newUser40);

    var newUser41 = InformationModel.Make<User>("Xavier41");
    userFolder.Add(newUser41);
    var newUser42 = InformationModel.Make<User>("Xavier42");
    userFolder.Add(newUser42);
    var newUser43 = InformationModel.Make<User>("Xavier43");
    userFolder.Add(newUser43);
    var newUser44 = InformationModel.Make<User>("Xavier44");
    userFolder.Add(newUser44);
    var newUser45 = InformationModel.Make<User>("Xavier45");
    userFolder.Add(newUser45);
    var newUser46 = InformationModel.Make<User>("Xavier46");
    userFolder.Add(newUser46);
    var newUser47 = InformationModel.Make<User>("Xavier47");
    userFolder.Add(newUser47);
    var newUser48 = InformationModel.Make<User>("Xavier48");
    userFolder.Add(newUser48);
    var newUser49 = InformationModel.Make<User>("Xavier49");
    userFolder.Add(newUser49);
    var newUser50 = InformationModel.Make<User>("Xavier50");
    userFolder.Add(newUser50);

    var newUser51 = InformationModel.Make<User>("Xavier51");
    userFolder.Add(newUser51);
    var newUser52 = InformationModel.Make<User>("Xavier52");
    userFolder.Add(newUser52);
    var newUser53 = InformationModel.Make<User>("Xavier53");
    userFolder.Add(newUser53);
    var newUser54 = InformationModel.Make<User>("Xavier54");
    userFolder.Add(newUser54);
    var newUser55 = InformationModel.Make<User>("Xavier55");
    userFolder.Add(newUser55);
    var newUser56 = InformationModel.Make<User>("Xavier56");
    userFolder.Add(newUser56);
    var newUser57 = InformationModel.Make<User>("Xavier57");
    userFolder.Add(newUser57);
    var newUser58 = InformationModel.Make<User>("Xavier58");
    userFolder.Add(newUser58);
    var newUser59 = InformationModel.Make<User>("Xavier59");
    userFolder.Add(newUser59);
    var newUser60 = InformationModel.Make<User>("Xavier60");
    userFolder.Add(newUser60);

    var newUser61 = InformationModel.Make<User>("Xavier61");
    userFolder.Add(newUser61);
    var newUser62 = InformationModel.Make<User>("Xavier62");
    userFolder.Add(newUser62);
    var newUser63 = InformationModel.Make<User>("Xavier63");
    userFolder.Add(newUser63);
    var newUser64 = InformationModel.Make<User>("Xavier64");
    userFolder.Add(newUser64);
    var newUser65 = InformationModel.Make<User>("Xavier65");
    userFolder.Add(newUser65);
    var newUser66 = InformationModel.Make<User>("Xavier66");
    userFolder.Add(newUser66);
    var newUser67 = InformationModel.Make<User>("Xavier67");
    userFolder.Add(newUser67);
    var newUser68 = InformationModel.Make<User>("Xavier68");
    userFolder.Add(newUser68);
    var newUser69 = InformationModel.Make<User>("Xavier69");
    userFolder.Add(newUser69);
    var newUser70 = InformationModel.Make<User>("Xavier70");
    userFolder.Add(newUser70);

    var newUser71 = InformationModel.Make<User>("Xavier71");
    userFolder.Add(newUser71);
    var newUser72 = InformationModel.Make<User>("Xavier72");
    userFolder.Add(newUser72);
    var newUser73 = InformationModel.Make<User>("Xavier73");
    userFolder.Add(newUser73);
    var newUser74 = InformationModel.Make<User>("Xavier74");
    userFolder.Add(newUser74);
    var newUser75 = InformationModel.Make<User>("Xavier75");
    userFolder.Add(newUser75);
    var newUser76 = InformationModel.Make<User>("Xavier76");
    userFolder.Add(newUser76);
    var newUser77 = InformationModel.Make<User>("Xavier77");
    userFolder.Add(newUser77);
    var newUser78 = InformationModel.Make<User>("Xavier78");
    userFolder.Add(newUser78);
    var newUser79 = InformationModel.Make<User>("Xavier79");
    userFolder.Add(newUser79);
    var newUser80 = InformationModel.Make<User>("Xavier80");
    userFolder.Add(newUser80);

    var newUser81 = InformationModel.Make<User>("Xavier81");
    userFolder.Add(newUser81);
    var newUser82 = InformationModel.Make<User>("Xavier82");
    userFolder.Add(newUser82);
    var newUser83 = InformationModel.Make<User>("Xavier83");
    userFolder.Add(newUser83);
    var newUser84 = InformationModel.Make<User>("Xavier84");
    userFolder.Add(newUser84);
    var newUser85 = InformationModel.Make<User>("Xavier85");
    userFolder.Add(newUser85);
    var newUser86 = InformationModel.Make<User>("Xavier86");
    userFolder.Add(newUser86);
    var newUser87 = InformationModel.Make<User>("Xavier87");
    userFolder.Add(newUser87);
    var newUser88 = InformationModel.Make<User>("Xavier88");
    userFolder.Add(newUser88);
    var newUser89 = InformationModel.Make<User>("Xavier89");
    userFolder.Add(newUser89);
    var newUser90 = InformationModel.Make<User>("Xavier90");
    userFolder.Add(newUser90);

    var newUser91 = InformationModel.Make<User>("Xavier91");
    userFolder.Add(newUser91);
    var newUser92 = InformationModel.Make<User>("Xavier92");
    userFolder.Add(newUser92);
    var newUser93 = InformationModel.Make<User>("Xavier93");
    userFolder.Add(newUser93);
    var newUser94 = InformationModel.Make<User>("Xavier94");
    userFolder.Add(newUser94);
    var newUser95 = InformationModel.Make<User>("Xavier95");
    userFolder.Add(newUser95);
    var newUser96 = InformationModel.Make<User>("Xavier96");
    userFolder.Add(newUser96);
    var newUser97 = InformationModel.Make<User>("Xavier97");
    userFolder.Add(newUser97);
    var newUser98 = InformationModel.Make<User>("Xavier98");
    userFolder.Add(newUser98);
    var newUser99 = InformationModel.Make<User>("Xavier99");
    userFolder.Add(newUser99);
    
    }
}
