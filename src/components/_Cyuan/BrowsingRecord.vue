<template>
  <div class="col">
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

<script>
import RecordRoom from "./RecordRoom.vue";
export default {
  components: {
    RecordRoom,
  },
  props: ["rooms", "nightCount"],
};
</script>