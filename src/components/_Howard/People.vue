<template>
    <div class="people">
        <div class="people-control">
          <div class="txt">
            <strong>成人</strong>
            <span>滿13歲</span>
          </div>
          <div>
            <button class="minus" @click="minus" id="adult-minus">-</button><span id="adult">{{adult}}</span
            ><button class="plus" @click="plus" id="adult-plus">+</button>
          </div>
        </div>
        <div class="people-control" id="child">
          <div class="txt">
            <strong>兒童</strong>
            <span>2 - 12歲</span>
          </div>
          <div>
            <button class="minus" @click="minus" id="child-minus">-</button><span>{{child}}</span
            ><button class="plus" @click="plus" id="child-plus">+</button>
          </div>
        </div>
        <div class="people-control" id="toddler">
          <div class="txt">
            <strong>嬰幼兒</strong>
            <span>2歲以下</span>
          </div>
          <div>
            <button class="minus" @click="minus" id="toddler-minus">-</button><span>{{toddler}}</span
            ><button class="plus" @click="plus" id="toddler-plus">+</button>
          </div>
        </div>
    </div>
</template>

<script>
export default {
  data(){
    return{
       adult:1,
       child:0,
       toddler:0
    }
  },
  methods:{
    plus(e){
      if(e.target.getAttribute('id')=='adult-plus') this.adult+=1;
      else if(e.target.getAttribute('id')=='child-plus') this.child+=1;
      else if(e.target.getAttribute('id')=='toddler-plus') this.toddler+=1;
      this.$emit('updateInfo',[(this.adult+this.child),this.toddler])
    },
    minus(e){
      if(e.target.getAttribute('id')=='adult-minus') this.adult-=1;
      else if(e.target.getAttribute('id')=='child-minus') this.child-=1;
      else if(e.target.getAttribute('id')=='toddler-minus') this.toddler-=1;
      this.$emit('updateInfo',[(this.adult+this.child),this.toddler])
    }
  },
  watch:{
    adult(val){
      if(val<1) this.adult = 1
    },
    child(val){
      if(val<0) this.child = 0
    },
    toddler(val){
      if(val<0) this.toddler = 0
    }
  }
}
</script>

<style lang="scss" scoped>
.people {
    display: flex;
    flex-direction: column;
    .people-control {
      display: flex;
      justify-content: space-between;
      align-items: center;
      padding: 1.2rem 0;
      &:not(:last-child) {
        border-bottom: 1px solid rgb(204, 201, 201);
      }
      margin: 0.3rem 2rem;
      .txt {
        display: flex;
        flex-direction: column;
        line-height: 1.2rem;
        strong {
          font-size: 1.2rem;
        }
        span {
          color: rgb(104, 102, 102);
          font-size: 0.9rem;
        }
      }
      button {
        width: 2rem;
        height: 2rem;
        margin: 0 0.8rem;
        border-radius: 50%;
        background-color: #fff;
        border: 1px solid rgb(204, 201, 201);
        font-size: 1.2rem;
      }
    }
}
</style>