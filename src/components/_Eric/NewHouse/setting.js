export default {
    houseCategories: [
        {
            type: 'Apartment',
            chinese: '公寓',
            mapping: 1,
            img: require('@/assets/pic/rent_page/apartment.jpg'),
            houseTypes: [
                {
                    type: 'RentalUnit',
                    chinese: '出租大樓',
                    description: '集合住宅大樓或複合式建築中的出租屋。',
                    mapping: 101,
                },
                {
                    type: 'Condo',
                    chinese: '私有公寓',
                    description: '位於集合住宅大樓或複合式建築的住處，產權歸住戶所有。',
                    mapping: 102,
                },
                {
                    type: 'Loft',
                    chinese: 'Loft空間',
                    description: '開放式的公寓，內牆可能較矮。',
                    mapping: 103,
                },
                {
                    type: 'ServicedApartment',
                    chinese: '服務式公寓',
                    description: '由專業管理公司提供飯店式管理服務的公寓。',
                    mapping: 104,
                },
                {
                    type: 'CasaParticular',
                    chinese: '古巴家庭旅館',
                    description: '古巴家庭旅館內的獨立房間。',
                    mapping: 105,
                },
            ]
        },
        {
            type: 'House',
            chinese: '獨棟房屋',
            mapping: 2,
            img: require('@/assets/pic/rent_page/House.jpg')
        },
        {
            type: 'SecondaryUnit',
            chinese: '附屬建築',
            mapping: 3,
            img: require('@/assets/pic/rent_page/SecondaryUnit.jpg')
        },
        {
            type: 'UniqueSpace',
            chinese: '獨特房源',
            mapping: 4,
            img: require('@/assets/pic/rent_page/UniqueSpace.jpg')
        },
        {
            type: 'BreakAndBreakfast',
            chinese: '家庭式旅館',
            mapping: 5,
            img: require('@/assets/pic/rent_page/BreakAndBreakfast.jpg')
        },
        {
            type: 'BoutiqueHotel',
            chinese: '精品旅館',
            mapping: 6,
            img: require('@/assets/pic/rent_page/BoutiqueHotel.jpg')
        },
    ],

    roomTypes: [
        {
            type: 'EntirePlace',
            chinese: '整套房源',
            mapping: 1,
        },
        {
            type: 'PrivateRoom',
            chinese: '獨立房間',
            mapping: 2,
        },
        {
            type: 'SharedRoom',
            chinese: '合住房間',
            mapping: 3,
        },
    ]
}