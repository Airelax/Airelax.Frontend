<template>
  <swiper
    :slidesPerView="1"
    :spaceBetween="0"
    :loop="false"
    :pagination="{
      clickable: true,
    }"
    :navigation="true"
    class="mySwiper"
  >
    <swiper-slide v-for="picture in roomPicture" :key="picture.index">
    </swiper-slide>
  </swiper>
</template>

<style scoped>
.swiper-container {
  width: 100%;
  height: 100%;
}

.swiper-slide {
  text-align: center;
  font-size: 18px;
  background: #fff;

  display: flex;
  justify-content: center;
  align-items: center;
}

.swiper-slide img {
  display: block;
  width: 100%;
  height: 100%;

  border: 1px solid #aaa;
  border-radius: 15px;
}

.swiper-container {
  margin-left: auto;
  margin-right: auto;
}
</style>

<script>
import { Swiper, SwiperSlide } from "swiper/vue";
import "swiper/swiper.scss";
import "swiper/components/pagination/pagination.scss";
import "swiper/components/navigation/navigation.scss";
import SwiperCore, { Pagination, Navigation } from "swiper/core";
SwiperCore.use([Pagination, Navigation]);
export default {
  components: {
    Swiper,
    SwiperSlide,
  },
  props: ["roomPicture"],
  mounted() {
    console.log(this.roomPicture);
  },
};
</script>