<template>
  <swiper
    :slidesPerView="1"
    :spaceBetween="0"
    :loop="false"
    :pagination="{
      clickable: true,
    }"
    :navigation="true"
    class="roomPicture"
  >
    <swiper-slide v-for="picture in roomPicture" :key="picture.index">
      <img :src="picture" />
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
import SwiperCore, { Pagination, Navigation } from "swiper/core";
SwiperCore.use([Pagination, Navigation]);
import "swiper/components/pagination/pagination.scss";
import "swiper/components/navigation/navigation.scss";
import "swiper/swiper.min.css";

export default {
  components: {
    Swiper,
    SwiperSlide,
  },
  props: ["roomPicture"],
};
</script>