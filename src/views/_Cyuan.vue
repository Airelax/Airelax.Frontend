<template>
  <div class="container-md" v-if="get">
    <div class="row">
      <div class="col-12 col-xl-6">
        <ResultRoom :rooms="rooms" :nightCount="nightCount"></ResultRoom>
        <BrowsingRecord
          :rooms="rooms"
          :nightCount="nightCount"
        ></BrowsingRecord>
      </div>
      <div class="d-none d-xl-block col-xl-6">
        <div class="map">
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Iste
            nesciunt asperiores quos, placeat tempora repudiandae explicabo
            aliquid ducimus ipsa similique soluta minus tenetur velit vero
            praesentium possimus, nam sed nemo autem. Molestiae, soluta quod
            repellat aut tenetur magni deserunt perferendis voluptates hic,
            numquam sed dicta fugit, dolorum reprehenderit libero reiciendis
            temporibus voluptatem alias? Aspernatur dolores veritatis magni unde
            hic voluptas saepe ipsum obcaecati nobis! Excepturi adipisci alias
            reprehenderit deleniti ut laborum fuga id omnis quis dicta. Non
            rerum quia quibusdam deleniti ut velit adipisci ipsa, quis sequi
            soluta voluptatum, explicabo, accusamus quae at qui tempore
            inventore natus recusandae ducimus! Sed?
          </p>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import axios from "axios";
import ResultRoom from "../components/_Cyuan/_cyuan.vue";
import BrowsingRecord from "../components/_Cyuan/BrowsingRecord.vue";
export default {
  components: {
    ResultRoom,
    BrowsingRecord,
  },
  data() {
    return {
      rooms: Array,
      nightCount: 3,
      get: false,
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
};
</script>