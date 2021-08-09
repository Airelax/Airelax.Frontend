<template>
  <div class="cardTemplate">
    <h2>住宿地點</h2>

    <div class="rooms">
      <div class="roomCards" v-for="(room, index) in roomDatas" :key="room.id">
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            <p class="card-text1">臥室{{ index + 1 }}</p>
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </div>
    </div>

    <div class="rooms">
      <div class="roomCards" v-for="(room, index) in roomDatas" :key="index">
        <div class="card" style="width: 10rem">
          <div class="card-body">
            <div
              class="beds"
              v-for="(bed, index) in room.BedCount"
              :key="index"
            >
              <div v-if="room.BedType == '單人床'">
                <svg
                  viewBox="0 0 32 32"
                  xmlns="http://www.w3.org/2000/svg"
                  aria-hidden="true"
                  role="presentation"
                  focusable="false"
                  style="
                    display: block;
                    height: 24px;
                    width: 24px;
                    fill: currentcolor;
                  "
                >
                  <path
                    d="M24 4a2 2 0 0 1 1.995 1.85L26 6v7.839l1.846 5.537a3 3 0 0 1 .115.468l.03.24.009.24V30h-2v-2H6v2H4v-9.675a3 3 0 0 1 .087-.717l.067-.232L6 13.836V6a2 2 0 0 1 1.697-1.977l.154-.018L8 4zm2 18H6v4h20zm-1.388-6H7.387l-1.333 4h19.891zM24 6H8v8h3v-4a2 2 0 0 1 1.85-1.995L13 8h6a2 2 0 0 1 1.995 1.85L21 10v4h3zm-5 4h-6v4h6z"
                  />
                </svg>
              </div>
            </div>

            <div
              class="beds"
              v-for="(bed, index) in room.BedCount"
              :key="index"
            >
              <div v-if="room.BedType == '雙人床'">
                <svg
                  viewBox="0 0 32 32"
                  xmlns="http://www.w3.org/2000/svg"
                  aria-hidden="true"
                  role="presentation"
                  focusable="false"
                  style="
                    display: block;
                    height: 24px;
                    width: 24px;
                    fill: currentcolor;
                  "
                >
                  <path
                    d="M26 4a2 2 0 0 1 1.995 1.85L28 6v7.839l1.846 5.537a3 3 0 0 1 .115.468l.03.24.009.24V30h-2v-2H4v2H2v-9.675a3 3 0 0 1 .087-.717l.067-.232L4 13.836V6a2 2 0 0 1 1.697-1.977l.154-.018L6 4zm2 18H4v4h24zm-1.388-6H5.387l-1.333 4h23.891zM26 6H6v8h2v-4a2 2 0 0 1 1.85-1.995L10 8h12a2 2 0 0 1 1.995 1.85L24 10v4h2zm-11 4h-5v4h5zm7 0h-5v4h5z"
                  />
                </svg>
              </div>
            </div>

            <p class="card-text1">臥室{{ index + 1 }}</p>
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </div>
    </div>
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
export default {
  components: {
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
  h2 {
  }
  .rooms {
    padding: auto;
    display: flex;
    flex-direction: row;
    width: 100%;
    overflow: hidden;
    margin-top: 20px;
    .roomCards {
      padding: 8px;

      .card {
        cursor: pointer;
        border: none;
        width: 100%;
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
          }
        }
      }
    }
  }
}
</style>