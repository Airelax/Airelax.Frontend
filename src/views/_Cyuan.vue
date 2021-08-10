<template>
  <div class="container-md">
    <div class="row">
      <div class="col-12 col-xl-6" v-if="get">
        <ResultRoom
          v-for="room in rooms"
          :key="room.id"
          :room="room"
          :nightCount="nightCount"
          @pricedetail="getprice"
        ></ResultRoom>
        <PriceDetail
          :price="pricedetail"
          :nightCount="nightCount"
        ></PriceDetail>

        <BrowsingRecord
          :rooms="rooms"
          :nightCount="nightCount"
        ></BrowsingRecord>
      </div>
    </div>
  </div>
</template>
<script>
import axios from "axios";
import PriceDetail from "../components/_Cyuan/PriceDetail.vue";
import ResultRoom from "../components/_Cyuan/_cyuan.vue";
import BrowsingRecord from "../components/_Cyuan/BrowsingRecord.vue";
export default {
  components: {
    PriceDetail,
    ResultRoom,
    BrowsingRecord,
  },
  data() {
    return {
      rooms: Array,
      nightCount: 3,
      get: false,
      pricedetail: null,
    };
  },
  created() {
    axios
      .get(
        "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/SHOP-48/fake-search-data.json"
      )
      .then((res) => {
        this.rooms = res.data;
        this.get = true;
      });
  },
  methods: {
    getprice(roomprice) {
      console.log(roomprice);
      this.pricedetail = roomprice;
    },
  },
};
</script>
