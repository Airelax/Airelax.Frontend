<template>
  <div class="cardTemplate">
    <h2><strong>住宿地點</strong></h2>

    <swiper
    :slides-per-view="2"
    :watchSlidesProgress="true"
    navigation
    @swiper="onSwiper"
    @slideChange="onSlideChange" 
    class="rooms">

      <swiper-slide class="roomCards col-6" v-for="(room, index) in roomDatas" :key="room.index">
        <div class="card">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            <h3 class="card-text1"><strong>臥室{{ index + 1 }}</strong></h3>
            <h4 class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</h4>
          </div>
        </div>
      </swiper-slide>

     
      
    </swiper>

    <swiper
    :slides-per-view="3"
    :space-between="1"
    navigation
    @swiper="onSwiper"
    @slideChange="onSlideChange" 
    class="rooms">
       <swiper-slide class="roomCards roomCardsWithOutPic col-6" v-for="(room, index) in roomDatas" :key="room.index">
        <div class="card">
          <div class="card-body">
            <div
              class="beds"
              v-for="(bed, index) in room.BedCount"
              :key="index"
            >
              <div class="singleBed" v-if="room.BedType == '單人床'">
                <img :src="require('@/assets/pic/bedWithoutPic/singleBed.svg')">
              </div>
            </div>

            <div
              class="beds"
              v-for="(bed, index) in room.BedCount"
              :key="index"
            >
              <div class="doubleBed" v-if="room.BedType == '雙人床'">
                <img  :src="require('@/assets/pic/bedWithoutPic/doubleBed.svg')">
              </div>
            </div>

            <h3 class="card-text1"><strong>臥室{{ index + 1 }}</strong></h3>
            <h4 class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</h4>
          </div>
        </div>
      </swiper-slide>
    </swiper>
    <!-- <Carousel
      :per-page="1"
      :perPageCustom="[
        [576, 1],
        [768, 2],
        [1024, 4],
      ]"
      :mouse-drag="true"
      :navigationEnabled="windowWidth >= 576 ? true : false"
      class="carousel-custom rooms"
    >
      <Slide
        
        v-for="(room, index) in roomDatas"
        :key="index"
      >
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </Slide>
    </Carousel> -->
  </div>
</template>

<script>
import axios from "axios";

//import activeRoomCards from "activeRoomCards.vue"
//import inactiveRoomCards from "inactiveRoomCards.vue"
//import bedRoomSlideButtons from "bedRoomSlideButtons.vue"
import SwiperCore, { Navigation, Pagination, Scrollbar, A11y } from 'swiper';
import {Swiper,SwiperSlide} from'swiper/vue';
import 'swiper/swiper.scss';
import 'swiper/components/navigation/navigation.scss';
import 'swiper/components/pagination/pagination.scss';
import 'swiper/components/scrollbar/scrollbar.scss';
SwiperCore.use([Navigation, Pagination, Scrollbar, A11y]);
//import SwiperSlider from './SwiperSlider.vue';
export default {
  components: {
    Swiper,
    SwiperSlide
    //SwiperSlider
    //activeRoomCards,
    //inactiveRoomCards,
    //bedRoomSlideButtons
  },
  data: function () {
    return {
      roomDatas: [],
    };
  },
  create() {},
  methods: {},
  mounted: function () {
    axios
      .get(
        "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/master/project/fake-room-data.json"
      )
      .then((response) => {
        console.log(response.data);
        this.roomDatas = response.data[0].BedroomDetail;
      });
  },
};
</script>

<style scoped lang="scss">
.cardTemplate {
  padding: 48px 0;
  .swiper-button-prev,
  .swiper-button-next {
    display: flex;
    align-items: center;
    justify-content: center;
    color: #000;
    font-weight: 600;
    background-color: #ffffff80;
    padding: 14px;
    border-radius: 50%;
  }
  h2 {
    text-align: start;
  }
  .rooms {
    display: flex;
    
    
    
    .roomCards {
      padding: 8px;

      .card {
        cursor: pointer;
        border: none;
        
        justify-content: start;
        text-align: start;
        border: 1px solid black;

        .roomPic {
          width: 100%;
          border-top-right-radius: 10px;
          border-top-left-radius: 10px;
        }

        .card-body {
          .beds {
            display: inline-block;
            .singleBed{
              width: 24px;
            }
            .doubleBed{
              width: 24px;
            }
          }
          h3{
            font-size: 16px;
          }
          h4{
            font-size: 4px;
          }
        }
      }
    }
  }
}
@media screen and (min-width :768px) {
  .cardTemplate{
    max-width: 653px;
    .roomCardsWithOutPic{
      width: 33.333%;
    }

    
  }
}
</style>