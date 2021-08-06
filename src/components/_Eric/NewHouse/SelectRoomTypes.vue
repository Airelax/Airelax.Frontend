<template>
  <li v-for="roomType in roomTypes" :key="roomType.mapping">
    <RoomType :roomType="roomType"></RoomType>
  </li>
</template>

<style lang="scss" scoped>
li {
  list-style: none;
  padding: 0;
}
</style>
<script>
import RoomType from "./RoomType.vue";

export default {
  props: {
    roomTypes: {
      type: Object,
    },
  },
  components: {
    RoomType,
  },
};
</script>