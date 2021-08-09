<template>
  <div class="cardTemplate">
    <h2>住宿地點</h2>

    <div class="rooms">
      <div class="roomCards" v-for="(room, index) in roomDatas" :key="room.id">
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
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