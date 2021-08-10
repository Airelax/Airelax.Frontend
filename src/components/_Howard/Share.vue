<template>
    <div class="back">
        <a href="#" class="backButton"  v-if="fullWidth < 768"><img src="@/assets/pic/icon/back.svg">房源 • Airbnb</a>
        <div class="function">
            <a href="#" class="share"><img src="@/assets/pic/icon/share.svg"><span>分享</span></a>
            <a href="#"><img src="@/assets/pic/icon/like.svg"><span>儲存</span></a>
        </div>
    </div>
</template>

<script>
export default {
  data(){
      return{
          fullWidth: 0,
          fullHeight: 0
      }
  },
  watch:{
      fullWidth(val){
          this.fullWidth = val;
      }
  },
  mounted() {
      const vm = this;
      this.fullWidth = document.body.clientWidth;
      window.addEventListener("resize", function() {
        vm.fullWidth = document.body.clientWidth;
      })
  }
}
</script>

<style lang="scss" scoped>
.back{
    display: flex;
    justify-content: space-between;
    margin: 1.5rem 2rem;
    a{
        display: flex;
        align-items: center;
        color: #222222;
        font-weight: 700;
        height: 2rem;
        border-radius: 8px;
        padding: .2rem;
        &:hover{
            background-color: #f3f3f3;
        }
        img{
            width: 1.2rem;
            margin-right: 0.5rem;
        }
        span{
            margin-left: .5rem;
        }
    }
    .function{
        display: flex;
        .share{
            margin: 0 1rem;
        }
        img{
            margin: unset;
        }
    }
}
@media screen and (min-width:768px){
    .back{
        margin: unset;
        a{
            padding: .5rem;
        }
    }
}
</style>