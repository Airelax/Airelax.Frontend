<template>
  <div
    class="col-12 col-md-4 eachRoomCol"
    type="button"
    v-for="room in rooms"
    :key="room.id"
  >
    <div class="row">
      <div class="label d-flex position-relative">
        <div class="perfect me-auto">超讚房東</div>
        <!-- heart 功能外觀一併 寫成component -->
        <div
          class="heart ms-auto d-none d-md-block"
          data-bs-toggle="offcanvas"
          data-bs-target="#mdList"
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
      <div><RoomSwiper :roomPicture="room.picture[0]"></RoomSwiper></div>
    </div>
    <div class="row">
      <div class="col">
        <div class="comment d-inline-flex">
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
          <span class="starScore">
            {{ room.comment.star }}
          </span>
          <span class="commentCount">({{ room.comment.TotalComments }})</span>
        </div>
        <div class="typeAddress">{{ room.houseType }}．{{ room.address }}</div>
        <div class="title">
          {{ room.Title }}
        </div>
      </div>
    </div>
    <div class="row">
      <div class="originAndSweet">
        <span class="origin"> $ {{ convertToLocaleString(room.Price) }} </span>
        <span class="sweetPrice">
          $
          {{ plusServiceFee(room.Price, nightCount) }}
          TWD
        </span>
        / 晚
      </div>
      <div class="total d-md-flex">
        <div
          class="totalLink"
          data-bs-toggle="offcanvas"
          data-bs-target="#mdDetail"
          aria-controls="offcanvasBottom"
        >
          總計 ${{ getTotal(room.Price, nightCount) }} TWD
        </div>
      </div>
      <PriceDetail
        :sweetPrices="room.Price.sweetPrice"
        :prices="room.Price"
        :nightCount="nightCount"
      ></PriceDetail>
    </div>
  </div>
</template>

<style lang="scss" scoped>
@import url("https://fonts.googleapis.com/css2?family=Noto+Sans+TC:wght@100;300;400;500;700;900&display=swap");
* {
  font-family: "Noto Sans TC", sans-serif;
  a {
    color: #000;
    text-decoration: none;
  }
  a:hover {
    color: #000;
  }
  .eachRoomCol {
    padding-right: 10px;
    position: relative;
    bottom: 20px;
    .row {
      text-align: start;
    }
    .row:nth-of-type(1) {
      .label {
        top: 38px;
        z-index: 10;
        padding: 0 20px;
        .perfect {
          font-size: 12px;
          letter-spacing: 1px;
          color: #000;
          background-color: #fff;
          border: 1px solid transparent;
          border-radius: 5px;
          padding: 3px 8px;
        }
        .heart {
          svg {
            height: 24px;
            width: 24px;
            fill: rgba(0, 0, 0, 0.5);
            stroke: rgb(255, 255, 255);
            stroke-width: 2;
            overflow: visible;
          }
        }
      }
    }
    .row:nth-of-type(2) {
      font-weight: 300;
      .col {
        .comment {
          .star {
            height: 14px;
            width: 14px;
            fill: #ff385c;
            margin: auto 4px;
          }
          .starScore,
          .commentCount {
            font-size: 14px;
          }
          .starScore {
            color: #000;
          }
          .commentCount {
            color: #717374;
            margin-left: 1px;
          }
        }
        .typeAddress,
        .mdTypeAddress {
          color: #000;
        }

        .title {
          color: #000;
          overflow: hidden;
          text-overflow: ellipsis;
          white-space: nowrap;
        }
      }
    }
    .row:nth-of-type(3) {
      color: #000;
      .originAndSweet {
        .sweetPrice,
        .origin {
          font-weight: 700;
        }
        .origin {
          color: #717176;
          text-decoration: line-through;
        }
      }
      .total {
        .totalLink {
          font-size: 15px;
          text-decoration: underline;
          color: #717171;
        }
        .totalLink:hover {
          text-decoration: underline #000;
        }
      }
    }
  }
}
@media screen and(min-width:768px) {
}
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
  mounted() {
    console.log(this.room.picture);
  },
};
</script>
