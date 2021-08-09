<template>
  <div class="cardTemplate">
    <h2>住宿地點</h2>
    <div class="app">
      <Carousel
        :autoplay="true"
        :duration="2000"
        :initIndex="2"
        :direction="true"
        directionMode="hover"
        :directionSize="20"
        directionColor="skyblue"
        :indicator="true"
        indicatorMode="always"
        indicatorColor="white"
        indicatorActiveColor="skyblue"
        @before-moving="beforeMoving"
        @after-moving="afterMoving"
      >
        <CarouselItem
          class="roomCards"
          v-for="(room, index) in roomDatas"
          :key="index"
          :idx="index"
        >
          <div class="card" style="width: 18rem">
            <img :src="room.picture" class="card-img-top roomPic" alt="..." />
            <div class="card-body">
              臥室{{ index + 1 }}
              <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
            </div>
          </div>
        </CarouselItem>
      </Carousel>
    </div>
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
//import SwiperCore, { Virtual } from "swiper";
//import { Swiper, SwiperSlide } from "swiper/vue";
//import { defineComponent, reactive, toRefs } from "vue";
//SwiperCore.use([Virtual]);

//import { onMounted } from '@vue/runtime-core';
//import { onMounted, ref, watch, nextTick} from '@vue/runtime-core';
//import { Carousel, Slide } from "vue3-carousel";//, Navigation

//import activeRoomCards from "activeRoomCards.vue"
//import inactiveRoomCards from "inactiveRoomCards.vue"
//import bedRoomSlideButtons from "bedRoomSlideButtons.vue"
//import {} from Vue
import { defineComponent, reactive, toRefs } from "vue";
export default defineComponent({
	name:"App",
  //components: {
    
    // Carousel,
    // Slide,
    // // Pagination,
    // Navigation,
    //activeRoomCards,
    //inactiveRoomCards,
    //bedRoomSlideButtons
  //},
   //data: function () {
    // const slides = Array.from({ length: 1000 }).map(
    //   (el, index) => `Slide ${index + 1}`
    // );
    // return {
    //   slides,
    // };
//   },
  setup() {

	  const state =reactive({
		  roomDatas:[],
	  });

	  
	  axios
        .get(
          "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/master/project/fake-room-data.json"
        )
        .then((response) => {
          console.log(response.data);
          roomDatas= response.data[0].BedroomDetail;
        });
    // onMounted(() => {
    //   const roomDatas = ref([]);
    //   let swiper = null;
    //   watch(roomDatas, () => {
    //     nextTick(() => {
    //       swiper.update();
    //     });
    //   });
      

    //   swiper = new Swiper(".swiper-container", {
    //     pagination: {
    //       el: ".swiper-container",
    //     },
    // //   });
    // });

    // function beforeMoving(dire) {
    //   console.log("before", dire);
    // },
    // function afterMoving(obj) {
    //   console.log("after", obj);
    // },

    return {
      ...toRefs(state),
      //beforeMoving,
      //afterMoving,
    };
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

//   create() {},
//   methods: {},
//   mounted: function () {},
});
</script>

<style scoped lang="scss">
// html,body{
// 	position:relative;
// 	height:100%;
// }
// body{
// 	background:#eee;
// 	font-size: 14px;
// 	margin: 0;
// 	padding:0;
// }
// .swiper-container{
// 	width: 100%;
// 	height: 100%;
// }
// .swiper-slide{
// 	display: -webkit-box;
// 	display: -ms-flexbox;
// 	display:-webkit-flex;
// 	display:flex;
// 	-webkit-box-pack:center;
// 	-ms-flex-pack:center;
// 	-webkit-justify-content:center;
// 	justify-content:center;
// 	-webkit-box-align:center;

// 	-ms-flex-align:center;
// 	-webkit-align-items:center;
// 	align-items:center;
// }
// .cardTemplate {
//   padding: 48px 0;
//   h2 {
//   }
//   //////////////////////////////////////////////
//   // Carousel{
//   //   display: flex;
//   //   flex-direction: row;

//   //   Slide{
//   //     width: 50px;
//   //   }
//   // }
//   // .carousel__item {
//   //   min-height: 200px;
//   //   width: 100%;
//   //   background-color: #642afb;
//   //   color: white;
//   //   font-size: 20px;
//   //   border-radius: 8px;
//   //   display: flex;
//   //   justify-content: center;
//   //   align-items: center;
//   // }
//   // .carousel__slide {
//   //   padding: 10px;
//   // }

//   // .carousel__prev,
//   // .carousel__next {
//   //   box-sizing: content-box;
//   //   border: 5px solid white;
//   // }
//   //////////////////////////////////////////////
// //   .rooms {
// //     padding: auto;
// //     display: flex;
// //     flex-direction: row;
// //     width: 100%;
// //     overflow: hidden;

// //     .roomCards {
// //       padding: 8px;

// //       .card {
// //         cursor: pointer;
// //         border: none;
// //         width: 100%;
// //         .roomPic {
// //           width: 100%;
// //           border-top-right-radius: 10px;
// //           border-top-left-radius: 10px;
// //         }

// //         .card-body {
// //         }
// //       }
// //     }
// //   }
// }
</style>