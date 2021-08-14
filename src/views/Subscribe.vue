<template>
  <div class="container">
    <!-- 上一頁 申請預訂 -->
    <FrontPage></FrontPage>
    <div class="row rwd">
      <div class="col-12 col-md-6">
        <div class="sticky">
          <SubRoom></SubRoom>
        </div>
      </div>
      <div class="col-12 col-md-6">
        <YourTrip></YourTrip>
        <div class="row priceDetail d-md-none">
          <h3>價格詳情</h3>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-6"></div>
          <div class="col-12">
            <div class="btn"></div>
          </div>
        </div>
        <PayWay></PayWay>
        <RequiredInfo></RequiredInfo>
        <Unsubscribe></Unsubscribe>
        <CheckAndSub></CheckAndSub>
      </div>
    </div>
  </div>
</template>
<style lang="scss">
@import "../assets/css/reset.css";
@import url(https://fonts.googleapis.com/css2?family=Noto+Sans+TC:wght@100;300;400;500;700;900&display=swap);
@import "../assets/sass/Subscribe/Subscribe.scss";
</style>
<script>
import SubRoom from "../components/Subscribe/SubRoom.vue";
import FrontPage from "../components/Subscribe/FrontPage.vue";
import YourTrip from "../components/Subscribe/YourTrip.vue";
import PayWay from "../components/Subscribe/PayWay.vue";
import RequiredInfo from "../components/Subscribe/RequiredInfo.vue";
import Unsubscribe from "../components/Subscribe/Unsubscribe.vue";
import CheckAndSub from "../components/Subscribe/CheckAndSub.vue";
export default {
  components: {
    SubRoom,
    FrontPage,
    YourTrip,
    PayWay,
    RequiredInfo,
    Unsubscribe,
    CheckAndSub,
  },
};
</script>
