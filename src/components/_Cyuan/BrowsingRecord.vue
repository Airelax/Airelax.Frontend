<template>
  <div class="record">
    <div class="row">
      <div class="col">
        <h3>近期瀏覽紀錄</h3>
        <p>已根據目前的搜尋條件更新日期與價格。</p>
      </div>
      <div class="col d-none d-md-blocks navigation"></div>
    </div>
    <div class="row">
      <div class="scroll">
        <RecordRoom :rooms="rooms" :nightCount="nightCount"></RecordRoom>
      </div>
    </div>
  </div>
</template>
<style lang="scss" scoped>
* {
  font-family: "Noto Sans TC", sans-serif;
  .record {
    padding-top: 30px;
    padding-right: 0;
    .row:nth-of-type(1) {
      .col:nth-of-type(1) {
        padding-top: 0;
        padding-bottom: 0;
        h3,
        p {
          padding: 0 8px;
          text-align: start;
          color: #000;
        }
        h3 {
          font-weight: 700;
        }
      }
    }
    .row:nth-of-type(2) {
      height: 500px;
      overflow: hidden;
      padding: 6px;
      .scroll {
        display: flex;
        flex-wrap: nowrap;
        overflow-x: scroll;
        height: 600px;
      }
    }
  }
}
@media screen and(min-width:768px) {
  .record {
    .row:nth-of-type(2) {
      height: 300px;
    }
  }
}
</style>
<script>
import RecordRoom from "./RecordRoom.vue";
export default {
  components: {
    RecordRoom,
  },
  props: {
    rooms: { type: Object },
    nightCount: { type: Number },
  },
  data() {
    return {
      pricedetail: null,
    };
  },
};
</script>