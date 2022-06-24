using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using System ;
using System.IO;
public class MySoftAutoEditor: MonoBehaviour
{


   
    [MenuItem("MySoft Editor/InitProject")]
    static void InitProject()
    {
       PlayerSettings.companyName = "";
        PlayerSettings.productName = "";
PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android,"com."+""+"."+"");
	DirectoryInfo d = new DirectoryInfo(@"Assets/_Game/_Sprites/_Textures");
FileInfo[] infos = d.GetFiles(); // get all files in directory
var idxf =1;
foreach(FileInfo f in infos)
{
            if(f.Name.Contains(".meta"))
            {
                continue; 
            }
 AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/"+f.Name , idxf.ToString() +".png");
            idxf += 1;
}

    }
 
    [MenuItem("MySoft Editor/renameclasses")]
    static void renameclasses()
    {
     
        AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Banner/frederickhoward.cs", "jeraldmckenzie.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Interstitial/mariondelong.cs", "doughancock.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/RewardedVideo/norbertmelton.cs", "randywatkins.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Settings/wilburdorsey.cs", "lanehan.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/nicolasberman.cs", "damondelarosa.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/gordonellis.cs", "lancemorrison.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/tylergilmore.cs", "alvaroburrows.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/winstonhowe.cs", "vernbaker.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/adantracy.cs", "winstonquezada.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/darenculver.cs", "ottodriscoll.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/glennblanton.cs", "quintonmckenna.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/janbryant.cs", "eugenethomas.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/myronsinclair.cs", "gilbertobui.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/sethwang.cs", "gonzaloervin.cs");
AssetDatabase.RenameAsset("Assets/randallkoch.cs", "coyschaffer.cs");


    }

[MenuItem("MySoft Editor/renamepngs")]
   static void renamepngs()
    {
      
        AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Bely y beto coloring alexnorwood.png", " vincecuevas.png");
AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Bely y beto coloring antoinecarney.png", " daviscohen.png");
AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Bely y beto coloring javieradkins.png", " billycornell.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring albertbeatty.png", " bartbolton.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring chestersiegel.png", " genefranklin.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring clarencechristensen.png", " jerrykaiser.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring donalddecker.png", " douglasswenson.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring emersonli.png", " randallconnolly.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring emiliolarson.png", " rooseveltmagee.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring eugeneludwig.png", " joshuajennings.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring gregoriojacobson.png", " quincytuttle.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring jacobherman.png", " gradysampson.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring lorenzolovett.png", " christopherwilkes.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring melvinherbert.png", " murrayjacobsen.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring norbertlyon.jpg", " silasrussell.jpg");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring rooseveltlay.png", " virgilfitzpatrick.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Bely y beto coloring williamdooley.png", " rolanddawson.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Bely y beto coloring hanskraft.png", " vernonnorton.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Bely y beto coloring miltonlowery.png", " isidrotravis.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Bely y beto coloring peterforeman.png", " kennyhirsch.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring donnelllynn.png", " jonathanconnors.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring gavinpierson.png", " loganmassey.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring hugosingh.png", " donnyfrancisco.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring jamalmontoya.png", " galeninman.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring jeanjohn.png", " georgequintana.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring johnstevens.png", " derekwashington.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Bely y beto coloring mikestafford.png", " adolfobrooks.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/3x/Bely y beto coloring angelokirby.png", " armandorocha.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring alexismckay.png", " billiecummins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring andresvaldez.png", " woodrowbarker.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring basilparis.png", " bernardpaul.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring christianthorne.png", " logansnow.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring clevelandmedina.png", " charlieobrien.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring dandailey.png", " maxberry.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring emiliomcfarland.png", " ramonhartley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring felipesmart.png", " billymosley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring groverfarrell.png", " antoniohilton.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring heathmeadows.png", " lonniecope.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring homerlangston.png", " warrenharvey.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring joeljohn.png", " cartermcbride.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring jordanmcconnell.png", " josephmoore.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring lavernebuchanan.png", " jacquesmacdonald.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring luismarshall.png", " rigobertoogden.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring marykirkland.png", " genebrowne.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring octaviogould.png", " brycekern.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring reedmeier.png", " chadtipton.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring timmyreid.png", " jamalbentley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring timsadler.png", " stevenpreston.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring vernonsheets.png", " darwincarey.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Bely y beto coloring williscoulter.png", " bufordsutton.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring armandmadden.png", " denverwall.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring brainlowry.png", " toddsmiley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring danedawson.png", " horacetackett.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring delmarperkins.png", " alexanderwoodward.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring donovanherman.png", " guillermobarrett.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring guadalupebroussard.png", " gonzalocrowell.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Bely y beto coloring rorycardenas.png", " maynardgoins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring arthurmccarty.png", " lionelmason.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring brandenwilliamson.png", " nolangreer.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring elvinburgess.png", " josephhoover.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring gabriellayton.png", " numberspack.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring kirbyochoa.png", " wilfredhardy.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring macklight.png", " freddynixon.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring masoncasillas.png", " sergioharden.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring randyparedes.png", " melvinwall.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Bely y beto coloring sonkirkland.png", " merrilldickey.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/2x/Bely y beto coloring luisvernon.png", " xavierquigley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/2x/Bely y beto coloring rolandburris.png", " zacherymorrow.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring alfredmueller.png", " bernarddickinson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring amosdugan.png", " sterlingplatt.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring billieholmes.png", " shawncorcoran.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring codycox.png", " floydakins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring darinfarris.png", " cleobarber.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring delmarvernon.png", " wilfredoheard.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring eliburnett.png", " rickbrantley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring frankieroot.png", " lorenschuster.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring neiljenkins.png", " numbersstubbs.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring philipmarquez.png", " harrybullock.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Bely y beto coloring stewartsolomon.png", " edmundgunn.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring bernardoshelton.png", " jaredmoore.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring bertdumas.png", " alvincalhoun.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring daleboyce.png", " ralphdelgado.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring edwingarland.png", " isaiahly.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring jeffreyrandall.png", " waynegunter.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring joshsalas.png", " perryshannon.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring julianperez.png", " winfredcarpenter.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring millardaustin.png", " galeackerman.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring ricardogomes.png", " geralddugan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Bely y beto coloring robertclayton.png", " joaquinlight.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring alexanderodonnell.png", " agustinramsey.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring arronbeltran.png", " ianwalters.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring clementchang.png", " sammiecabral.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring donovanquezada.png", " marvinamos.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring frankiemccabe.png", " warrenday.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring gerrymcghee.png", " julioswartz.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring houstontrent.png", " waynestafford.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring jessebender.png", " bryonernst.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring kennethhatfield.png", " scottyforbes.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring olliemckenna.png", " colbycarrillo.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Bely y beto coloring thomasfrederick.png", " jeromegood.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring carlcasillas.png", " danieljefferson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring carybateman.png", " williamsburch.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring codymoser.png", " roscoeworkman.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring glenngabriel.png", " kirkhunter.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring jamieyanez.png", " isaiahvinson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring jarrodquinones.png", " rubenbond.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring jonathonforrest.png", " numbersgates.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/Bely y beto coloring kerryrush.png", " josueledford.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring arnoldbradley.png", " joeadair.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring barrymoran.png", " jakegoins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring cliffmcdowell.png", " patbergeron.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring dirkgrant.png", " byronlarson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring felixcraig.png", " fredrickmcclellan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring genarosandoval.png", " wilfredocooley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring harrislin.png", " reynaldolanders.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring jodymccann.png", " lamontgates.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring lionellackey.png", " jamesbacon.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring randallfunk.png", " warrenparks.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring silasdaniel.png", " cartermays.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring tysonbradford.png", " alejandrohopkins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Bely y beto coloring virgilburrell.png", " carltonogden.png");
AssetDatabase.RenameAsset("Assets/_Game/Bely y beto coloring denvergregory.png", " maxwellduong.png");
AssetDatabase.RenameAsset("Assets/ICOddN.png", " robbyleslie.png");


    }
[MenuItem("MySoft Editor/newguids")]
  static void newguids()
    {
        RegenerateGuids();


    }

[MenuItem("MySoft Editor/newguidForprojectOnly")]
  static void newguidForprojectOnly()
    {
        RegenerateGuids2();


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public static void RegenerateGuids() {
            if (EditorUtility.DisplayDialog("GUIDs regeneration",
                "You are going to start the process of GUID regeneration. This may have unexpected results. \n\n MAKE A PROJECT BACKUP BEFORE PROCEEDING!",
                "Regenerate GUIDs", "Cancel")) {
                try {
                    AssetDatabase.StartAssetEditing();

                    string path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "ProjectSettings";
                    UnityGuidRegenerator regenerator = new UnityGuidRegenerator(path);
                    regenerator.RegenerateGuids();
                      path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "Assets";
                    UnityGuidRegenerator regenerator2 = new UnityGuidRegenerator(path);
                    regenerator2.RegenerateGuids();
                }
                finally {
                    AssetDatabase.StopAssetEditing();
                    EditorUtility.ClearProgressBar();
                    AssetDatabase.Refresh();
                }
            }
        }



 public static void RegenerateGuids2() {
            if (EditorUtility.DisplayDialog("GUIDs regeneration",
                "You are going to start the process of GUID regeneration. This may have unexpected results. \n\n MAKE A PROJECT BACKUP BEFORE PROCEEDING!",
                "Regenerate GUIDs", "Cancel")) {
                try {
                    AssetDatabase.StartAssetEditing();

                    string path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "ProjectSettings";
                    UnityGuidRegenerator regenerator = new UnityGuidRegenerator(path);
                    regenerator.RegenerateGuids();
 
                }
                finally {
                    AssetDatabase.StopAssetEditing();
                    EditorUtility.ClearProgressBar();
                    AssetDatabase.Refresh();
                }
            }
        }
    }
 
    internal class UnityGuidRegenerator {
        private static readonly string[] kDefaultFileExtensions = {
            "*.meta",
            "*.mat",
            "*.anim",
            "*.prefab",
            "*.unity",
            "*.asset"
        };

        private readonly string _assetsPath;

        public UnityGuidRegenerator(string assetsPath) {
            _assetsPath = assetsPath;
        }

        public void RegenerateGuids(string[] regeneratedExtensions = null) {
            if (regeneratedExtensions == null) {
                regeneratedExtensions = kDefaultFileExtensions;
            }

            // Get list of working files
            List<string> filesPaths = new List<string>();
            foreach (string extension in regeneratedExtensions) {
                filesPaths.AddRange(
                    Directory.GetFiles(_assetsPath, extension, SearchOption.AllDirectories)
                    );
            }

            // Create dictionary to hold old-to-new GUID map
            Dictionary<string, string> guidOldToNewMap = new Dictionary<string, string>();
            Dictionary<string, List<string>> guidsInFileMap = new Dictionary<string, List<string>>();

            // We must only replace GUIDs for Resources present in Assets. 
            // Otherwise built-in resources (shader, meshes etc) get overwritten.
            HashSet<string> ownGuids = new HashSet<string>();

            // Traverse all files, remember which GUIDs are in which files and generate new GUIDs
            int counter = 0;
            foreach (string filePath in filesPaths) {
                EditorUtility.DisplayProgressBar("Scanning Assets folder", MakeRelativePath(_assetsPath, filePath), counter / (float) filesPaths.Count);
                string contents = File.ReadAllText(filePath);
                
                IEnumerable<string> guids = GetGuids(contents);
                IEnumerable<string> guids2 = GetGuids2(contents);
                IEnumerable<string> guids3 = guids.Concat(guids2);

                bool isFirstGuid = true;
                foreach (string oldGuid in guids3) {
                    // First GUID in .meta file is always the GUID of the asset itself
                    if (isFirstGuid && Path.GetExtension(filePath) == ".meta") {
                        ownGuids.Add(oldGuid);
                        isFirstGuid = false;
                    }
                    // Generate and save new GUID if we haven't added it before
                    if (!guidOldToNewMap.ContainsKey(oldGuid)) {
                        string newGuid = Guid.NewGuid().ToString("N");
                        guidOldToNewMap.Add(oldGuid, newGuid);
                    }

                    if (!guidsInFileMap.ContainsKey(filePath))
                        guidsInFileMap[filePath] = new List<string>();

                    if (!guidsInFileMap[filePath].Contains(oldGuid)) {
                        guidsInFileMap[filePath].Add(oldGuid);
                    }
                }

                counter++;
            }

            // Traverse the files again and replace the old GUIDs
            counter = -1;
            int guidsInFileMapKeysCount = guidsInFileMap.Keys.Count;
            foreach (string filePath in guidsInFileMap.Keys) {
                EditorUtility.DisplayProgressBar("Regenerating GUIDs", MakeRelativePath(_assetsPath, filePath), counter / (float) guidsInFileMapKeysCount);
                counter++;

                string contents = File.ReadAllText(filePath);
                foreach (string oldGuid in guidsInFileMap[filePath]) {
                    if (filePath.Contains("ProjectSettings"))
                    {
   if (filePath.Contains("ProjectSettings.asset"))
                    {
                        string newGuid = guidOldToNewMap[oldGuid];
                        if (string.IsNullOrEmpty(newGuid))
                            throw new NullReferenceException("newGuid == null");

                        contents = contents.Replace("guid: " + oldGuid, "guid: " + newGuid);
                        contents = contents.Replace("productGUID: " + oldGuid, "productGUID: " + newGuid);
}
                    }
                    else
                    {
                        if (!ownGuids.Contains(oldGuid))
                            continue;

                        string newGuid = guidOldToNewMap[oldGuid];
                        if (string.IsNullOrEmpty(newGuid))
                            throw new NullReferenceException("newGuid == null");

                        contents = contents.Replace("guid: " + oldGuid, "guid: " + newGuid);
                    }
                    File.WriteAllText(filePath, contents);
                }
                   
            }

            EditorUtility.ClearProgressBar();
        }

        private static IEnumerable<string> GetGuids(string text) {
            const string guidStart = "guid: ";
            const int guidLength = 32;
            int textLength = text.Length;
            int guidStartLength = guidStart.Length;
            List<string> guids = new List<string>();

            int index = 0;
            while (index + guidStartLength + guidLength < textLength) {
                index = text.IndexOf(guidStart, index, StringComparison.Ordinal);
                if (index == -1)
                    break;

                index += guidStartLength;
                string guid = text.Substring(index, guidLength);
                index += guidLength;

                if (IsGuid(guid)) {
                    guids.Add(guid);
                }
            }

            return guids;
        }

        private static IEnumerable<string> GetGuids2(string text)
        {
            const string guidStart = "productGUID: ";
            const int guidLength = 32;
            int textLength = text.Length;
            int guidStartLength = guidStart.Length;
            List<string> guids = new List<string>();

            int index = 0;
            while (index + guidStartLength + guidLength < textLength)
            {
                index = text.IndexOf(guidStart, index, StringComparison.Ordinal);
                if (index == -1)
                    break;

                index += guidStartLength;
                string guid = text.Substring(index, guidLength);
                index += guidLength;

                if (IsGuid(guid))
                {
                    guids.Add(guid);
                }
            }

            return guids;
        }
        private static bool IsGuid(string text) {
            for (int i = 0; i < text.Length; i++) {
                char c = text[i];
                if (
                    !((c >= '0' && c <= '9') ||
                      (c >= 'a' && c <= 'z'))
                    )
                    return false;
            }

            return true;
        }

        private static string MakeRelativePath(string fromPath, string toPath) {
            Uri fromUri = new Uri(fromPath);
            Uri toUri = new Uri(toPath);

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath;
        }	


}