<template>
  <div class="cardTemplate">
    <h2>住宿地點</h2>

    <swiper class="rooms" :slides-per-view="3" :space-between="50" virtual>
      <swiper-slide
        class="roomCards"
        v-for="(room, index) in roomDatas"
        :key="index"
        :virtualIndex="index"
      >
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </swiper-slide>
    </swiper>
    <!-- <Carousel :settings="settings" :breakpoints="breakpoints">
      <Slide v-for="(room, index) in roomDatas" :key="index">
        <div class="card carousel__item">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
            <p class="card-text2" v-if="room.BedType == '單人床'">
              {{ room.BedCount }}張{{ room.BedType }}
            </p>
          </div>
        </div>
      </Slide>

      <template #addons>
        <Navigation />
        <Pagination />
      </template>
    </Carousel> -->
  </div>
</template>

<script>
import axios from "axios";
import SwiperCore, { Virtual } from "swiper";
import { Swiper, SwiperSlide } from "swiper/vue";

SwiperCore.use([Virtual]);

//import { onMounted } from '@vue/runtime-core';
//import { Carousel, Slide } from "vue3-carousel";//, Navigation

//import activeRoomCards from "activeRoomCards.vue"
//import inactiveRoomCards from "inactiveRoomCards.vue"
//import bedRoomSlideButtons from "bedRoomSlideButtons.vue"
//import {} from Vue
export default {
  components: {
    Swiper,
    SwiperSlide,
    // Carousel,
    // Slide,
    // // Pagination,
    // Navigation,
    //activeRoomCards,
    //inactiveRoomCards,
    //bedRoomSlideButtons
  },
  data: function () {
    const slides = Array.from({ length: 1000 }).map(
      (el, index) => `Slide ${index + 1}`
    );
    return {
      slides,
    };
  },
  setup() {
    onMounted(() => {
      const roomDatas = ref([]);
      let swiper = null;
      watch(roomDatas, () => {
        nextTick(() => {
          swiper.update();
        });
      });
      axios
        .get(
          "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/master/project/fake-room-data.json"
        )
        .then((response) => {
          console.log(response.data);
          roomDatas.value = response.data[0].BedroomDetail;
        });

      swiper = new Swiper(".swiper-container", {
        pagination: {
          el: ".swiper-container",
        },
      });
    });

    return {};
  },

  // setup() {
  //   return {
  //     // carousel settings
  //     settings: {
  //       itemsToShow: 1,
  //       snapAlign: "center",
  //     },
  //     // breakpoints are mobile first
  //     // any settings not specified will fallback to the carousel settings
  //     breakpoints: {
  //       // 700px and up
  //       700: {
  //         itemsToShow: 3.5,
  //         snapAlign: "center",
  //       },
  //       // 1024 and up
  //       1024: {
  //         itemsToShow: 5,
  //         snapAlign: "start",
  //       },
  //     },
  //   };
  // },

  create() {},
  methods: {},
  mounted: function () {},
};
</script>

<style scoped lang="scss">
.cardTemplate {
  padding: 48px 0;
  h2 {
  }
  //////////////////////////////////////////////
  // Carousel{
  //   display: flex;
  //   flex-direction: row;

  //   Slide{
  //     width: 50px;
  //   }
  // }
  // .carousel__item {
  //   min-height: 200px;
  //   width: 100%;
  //   background-color: #642afb;
  //   color: white;
  //   font-size: 20px;
  //   border-radius: 8px;
  //   display: flex;
  //   justify-content: center;
  //   align-items: center;
  // }
  // .carousel__slide {
  //   padding: 10px;
  // }

  // .carousel__prev,
  // .carousel__next {
  //   box-sizing: content-box;
  //   border: 5px solid white;
  // }
  //////////////////////////////////////////////
  .rooms {
    padding: auto;
    display: flex;
    flex-direction: row;
    width: 100%;
    overflow: hidden;

    .roomCards {
      padding: 8px;

      .card {
        cursor: pointer;
        border: none;
        width: 100%;
        .roomPic {
          width: 100%;
          border-top-right-radius: 10px;
          border-top-left-radius: 10px;
        }

        .card-body {
        }
      }
    }
  }
}
</style>