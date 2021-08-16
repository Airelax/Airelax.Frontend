namespace Airelax.Domain.Houses.Defines
{
    public enum Facility
    {
        // 1xx bath
        Tub = 101, //浴缸
        Bidet = 102, //坐浴盆
        BodySoap = 103, //沐浴露 沐浴乳
        CleaningProducts = 104, //清潔產品
        Conditioner = 105, //潤髮乳
        HairDryer = 106, //吹風機
        HotWater = 107, //熱水
        OutDoorShower = 108, //戶外沐浴空間
        Shampoo = 109, //洗髮露

        // 2xx bathroom and wash
        Essentials = 201, //生活必需品
        BedLinens = 202, //床單
        ClothingStorage = 203, //衣櫥
        Dryer = 204, //乾衣機
        Clotheshorse = 205, //曬衣架(竿)
        ExtraBedding = 206, //額外的枕頭與毛毯
        Hanger = 207, //衣架
        Iron = 208, //熨斗
        MosquitoNet = 209, //蚊帳
        Curtain = 210, // 窗簾
        Washer = 211, //洗衣機

        // 3xx Entertainment
        Books = 301, //書
        Ethernet = 302, //網路線
        ExerciseEquipment = 303, //運動器材
        GameHost = 304, //遊戲主機
        Piano = 305,
        PingPangTable = 306, //乒乓球桌
        PoolTable = 307, //撞球桌
        RecordPlayer = 308, //黑膠唱片機
        Audio = 309, //音響
        Television = 310, //電視

        // 4xx Family
        BabyBath = 401, //嬰兒浴盆
        BabyMonitor = 402, //嬰兒監視器
        BabySafetyGates = 403, //嬰兒安全門欄
        BabysitterRecommendations = 404, //臨時保母推薦
        BoardGames = 405, //桌遊
        ChangingTable = 406, //尿布台
        Toys = 407,  //童書與玩具
        ChildrenDinnerware = 408, //兒童餐桌
        Crib = 409, //嬰兒床
        FireplaceGuards = 410, //壁爐護欄
        HighChair = 411, //兒童高腳椅
        OutletCovers = 412, // 插座蓋
        TravelCrib = 413, // 旅行用嬰兒床
        TableCornerGuards = 414, // 桌腳防護
        WindowGuards = 415, //窗柵

        // 5xx AirConditioner

        AirConditioner = 501, //空調設備
        CeilingFan = 502, //吊扇
        Heating = 503, //暖氣
        IndoorFireplace = 504, //室內壁爐
        PortableFans = 505, //移動式電扇

        // 6xx Safety
        CarbonMonoxideAlarm = 601, //一氧化碳警報器
        FireExtinguisher = 602, //滅火器
        FirstAidKit = 603, //急救包
        LockOnBedroom = 604, //帶鎖的臥室
        SmokeAlarm = 605, //煙霧警報器

        //7xx office
        WorkSpace = 701, //專門工作空間
        PocketWifi = 702, //可攜式WIFI
        Wifi = 703, //無線網路

        //8xx Kitchen
        BakingSheet = 801, //烤盤
        BarbecueUtensils = 802, //燒烤用具
        BreadMaker = 803, //烤麵包機
        Blender = 804, //調理機
        Coffee = 805, //咖啡
        CoffeeMaker = 806, //咖啡機
        CookingBasics = 807, //基本廚具
        DiningTable = 808, //餐桌
        DishesAndSilverware = 809, //盤子和餐具
        Dishwasher = 810, //洗碗機
        Freezer = 811, //冷凍庫
        HotWaterKettle = 812, //熱水壺
        Kitchen = 813, //廚房
        Microwave = 814, //微波爐
        MiniFridge = 815, //小冰箱
        Oven = 816, //烤箱
        Refrigerator = 817, //冰箱
        RiceMaker = 818, //電鍋
        Stove = 819, //爐子
        Toaster = 820, //烤麵包機
        TrashCompactor = 821, //壓縮式垃圾桶
        WineGlasses = 822, //葡萄酒杯

        //9xx Location features
        BeachAccess = 901, //直達海灘
        LakeAccess = 902, //直達湖畔
        LaundromatNearby = 903, //附近有自助洗衣店
        PrivateEntrance = 904, //獨立入口
        ResortAccess = 905, //渡假村入場證
        SkiOut = 906, //無須搭乘交通工具即可前往滑雪場
        Waterfront = 907, //緊鄰水岸

        //10xx outdoor 
        Backyard = 1001, //後院
        BBQ = 1002, //烤肉區
        BeachEssentials = 1003, //沙灘必備物品
        Bikes = 1004, //自行車
        BoatSlip = 1005, //船梯
        FirePit = 1006, //火坑
        Hammock = 1007, //吊床
        Kayak = 1008, //小輕艇
        OutdoorDiningArea = 1009, //室外用餐區
        OutdoorFurniture = 1010, //戶外家具
        OutdoorKitchen = 1011, //戶外廚房
        Patio = 1012, //庭院

        //11xx Parking and other
        Elevator = 1101, //電梯
        EVCharger = 1102, // 電動汽車充電設備
        FreeBuildingParking = 1103, //建築物內免費停車
        FreeStreetParking = 1104, //路邊有免費停車
        Gym = 1105, //健身房
        Jacuzzi = 1106, //按摩浴缸
        PaidParkingOffPremises = 1107, //建築物範圍外有收費停車
        PaidParkingOnPremises = 1108, //建築物內有收費停車位
        Pool = 1109, //游泳池
        PrivateLivingRoom = 1110, //獨立客廳
        Sauna = 1111, //三溫暖
        SingleLevelHome = 1112, //獨立房屋

        //12xx Services
        Breakfast = 1201, //早餐
        CleaningBeforeCheckout = 1202, // 退房前打掃
        LongTermStaysAllowed = 1203, //可長期住宿
        LuggageDropOffAllowed = 1204, //可存放行李
    }
}