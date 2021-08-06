<template>
  <div
    class="row eachRoom d-md-flex align-items-center"
    v-for="room in rooms"
    :key="room.id"
    type="button"
  >
    <div class="col-12 col-md-5">
      <div class="label d-flex flex-row">
        <div class="perfect">超讚房東</div>
        <!-- heart 功能外觀一併 寫成component -->
        <div
          class="heart d-md-none"
          data-bs-toggle="offcanvas"
          data-bs-target="#list"
          aria-controls="offcanvasBottom"
        >
          <svg
            viewBox="0 0 32 32"
            xmlns="http://www.w3.org/2000/svg"
            aria-hidden="true"
            role="presentation"
            focusable="false"
          >
            <path
              d="m16 28c7-4.733 14-10 14-17 0-1.792-.683-3.583-2.05-4.95-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05l-2.051 2.051-2.05-2.051c-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05-1.367 1.367-2.051 3.158-2.051 4.95 0 7 7 12.267 14 17z"
            ></path>
          </svg>
        </div>
      </div>
      <Wish></Wish>
      <RoomSwiper :roomPicture="room.picture[0]"></RoomSwiper>
    </div>
    <div class="col-12 col-md-7">
      <div class="row commentInfoTitle">
        <div class="col col-md-11">
          <div class="comment d-md-none">
            <svg
              class="star"
              viewBox="0 0 32 32"
              xmlns="http://www.w3.org/2000/svg"
              aria-hidden="true"
              role="presentation"
              focusable="false"
            >
              <path
                d="M15.094 1.579l-4.124 8.885-9.86 1.27a1 1 0 0 0-.542 1.736l7.293 6.565-1.965 9.852a1 1 0 0 0 1.483 1.061L16 25.951l8.625 4.997a1 1 0 0 0 1.482-1.06l-1.965-9.853 7.293-6.565a1 1 0 0 0-.541-1.735l-9.86-1.271-4.127-8.885a1 1 0 0 0-1.814 0z"
                fill-rule="evenodd"
              ></path>
            </svg>
            <span class="starScore" id="starScore">
              {{ room.comment.star }}
            </span>
            <span class="commentCount" id="commentCount"
              >({{ room.comment.TotalComments }})</span
            >
          </div>
          <div class="info d-md-none">
            <a href="#">
              <span class="roomCategory" id="roomCategory">{{
                room.houseType
              }}</span
              >、
              <span class="town" id="town">{{ room.address }}</span>
            </a>
          </div>
          <div class="mdinfo d-none d-md-block">
            <div>位於{{ room.address }}的{{ room.houseType }}</div>
          </div>
          <div class="title">
            <a href="#">
              <p class="roomTitle" id="roomTitle">{{ room.Title }}</p>
            </a>
          </div>
        </div>
        <div class="col-md-1 d-none d-md-block">
          <div class="mdHeart d-none d-md-block">
            <a
              href="#"
              class="mdWish"
              data-bs-toggle="offcanvas"
              data-bs-target="#mdWish"
              aria-controls="offcanvasBottom"
            >
              <svg
                class="svgmdheart"
                viewBox="0 0 32 32"
                xmlns="http://www.w3.org/2000/svg"
                aria-hidden="true"
                role="presentation"
                focusable="false"
              >
                <path
                  d="m16 28c7-4.733 14-10 14-17 0-1.792-.683-3.583-2.05-4.95-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05l-2.051 2.051-2.05-2.051c-1.367-1.366-3.158-2.05-4.95-2.05-1.791 0-3.583.684-4.949 2.05-1.367 1.367-2.051 3.158-2.051 4.95 0 7 7 12.267 14 17z"
                ></path>
              </svg>
            </a>
          </div>
        </div>
      </div>
      <div class="row spacerow d-none d-md-block">
        <p class="space">
          <span v-if="room.Space.CustomerNumber" class="customer">
            {{ room.Space.CustomerNumber }}位．</span
          >
          <span v-if="room.Space.Bedroom" class="bedRoom">
            {{ room.Space.Bedroom }}間臥室．</span
          >
          <span v-if="room.Space.Bed" class="bed">
            {{ room.Space.Bed }}張床．</span
          >
          <span v-if="room.Space.Bathroom" class="bathRoom">
            {{ room.Space.Bathroom }}間衛浴
          </span>
        </p>
        <p class="facility">
          <span v-if="room.facility.AirConditioner">冷氣．</span>
          <span v-if="room.facility.Kitchen">廚房．</span>
          <span v-if="room.facility.wifi">Wifi．</span>
          <span v-if="room.facility.WashingMachine">洗衣機</span>
        </p>
      </div>
      <div class="row pricerow">
        <div class="originAndSweet text-md-end">
          <span class="origin" id="origin">
            $ {{ convertToLocaleString(room.Price) }}
          </span>
          <span class="sweetPrice" id="sweetPrice">
            $
            {{ plusServiceFee(room.Price, nightCount) }}
            TWD
          </span>
          / 晚
        </div>
        <div class="total d-md-flex">
          <a href="#" class="mdStarLink d-none d-md-inline-flex me-md-auto">
            <svg
              class="star"
              viewBox="0 0 32 32"
              xmlns="http://www.w3.org/2000/svg"
              aria-hidden="true"
              role="presentation"
              focusable="false"
            >
              <path
                d="M15.094 1.579l-4.124 8.885-9.86 1.27a1 1 0 0 0-.542 1.736l7.293 6.565-1.965 9.852a1 1 0 0 0 1.483 1.061L16 25.951l8.625 4.997a1 1 0 0 0 1.482-1.06l-1.965-9.853 7.293-6.565a1 1 0 0 0-.541-1.735l-9.86-1.271-4.127-8.885a1 1 0 0 0-1.814 0z"
                fill-rule="evenodd"
              ></path>
            </svg>
            <span class="starScore fw-bold" id="starScore">
              {{ room.comment.star }}
            </span>
            <span class="commentCount" id="commentCount"
              >({{ room.comment.TotalComments }}則評論)</span
            >
          </a>
          <a
            href="#"
            class="totalLink d-md-none"
            data-bs-toggle="offcanvas"
            data-bs-target="#detail"
            aria-controls="offcanvasBottom"
            >總計 ${{ getTotal(room.Price, nightCount) }} TWD
          </a>
          <a
            href="#"
            class="totalLink d-none d-md-inline ms-md-auto"
            data-bs-toggle="offcanvas"
            data-bs-target="#mddetail"
            aria-controls="offcanvasBottom"
            >總計 ${{ getTotal(room.Price, nightCount) }} TWD
          </a>
        </div>
        <PriceDetail
          :sweetPrices="room.Price.sweetPrice"
          :prices="room.Price"
          :nightCount="nightCount"
        ></PriceDetail>
      </div>
    </div>
  </div>
</template>

<style lang="scss">
@import url("https://fonts.googleapis.com/css2?family=Noto+Sans+TC:wght@100;300;400;500;700;900&display=swap");
@import "@/assets/sass/_cyuan.scss";
</style>

<script>
import RoomSwiper from "./Swiper.vue";
import PriceDetail from "./PriceDetail.vue";
import Wish from "./Wish.vue";
export default {
  components: {
    RoomSwiper,
    PriceDetail,
    Wish,
  },
  props: ["rooms", "nightCount"],
  methods: {
    convertToLocaleString(price) {
      return price.origin.toLocaleString();
    },
    plusServiceFee(price, nightCount) {
      return Math.round(
        (Number(price.sweetPrice) * nightCount + Number(price.Fee.ServiceFee)) /
          nightCount
      ).toLocaleString();
    },
    getTotal(price, nightCount) {
      let feeTotal;
      let cleanFee = price.Fee.CleanFee;
      let taxFee = price.Fee.taxFee;
      let serviceFee = price.Fee.ServiceFee;
      if (!!cleanFee && !!taxFee)
        feeTotal = Number(cleanFee) + Number(serviceFee) + Number(taxFee);
      else if (cleanFee && !!taxFee)
        feeTotal = Number(serviceFee) + Number(cleanFee);
      else if (!!cleanFee && taxFee)
        feeTotal = Number(taxFee) + Number(serviceFee);
      else {
        feeTotal = Number(serviceFee);
      }
      return (
        Number(price.sweetPrice) * nightCount +
        feeTotal
      ).toLocaleString();
    },
  },
};
</script>
