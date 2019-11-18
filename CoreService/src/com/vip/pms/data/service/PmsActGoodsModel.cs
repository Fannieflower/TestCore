using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActGoodsModel {
		
		///<summary>
		/// 商品尺码ID
		///</summary>
		
		private long? mSizeId_;
		
		///<summary>
		/// 商品价格
		///</summary>
		
		private double? arrivalPrice_;
		
		///<summary>
		/// 商品专场ID
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 商品MID 
		///</summary>
		
		private long? mid_;
		
		///<summary>
		/// 商品vSkuId
		///</summary>
		
		private long? vSkuId_;
		
		///<summary>
		/// 商品的限量总数
		///</summary>
		
		private int? totalQuota_;
		
		///<summary>
		/// 商品优惠
		///</summary>
		
		private double? fav_;
		
		public long? GetMSizeId(){
			return this.mSizeId_;
		}
		
		public void SetMSizeId(long? value){
			this.mSizeId_ = value;
		}
		public double? GetArrivalPrice(){
			return this.arrivalPrice_;
		}
		
		public void SetArrivalPrice(double? value){
			this.arrivalPrice_ = value;
		}
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public long? GetMid(){
			return this.mid_;
		}
		
		public void SetMid(long? value){
			this.mid_ = value;
		}
		public long? GetVSkuId(){
			return this.vSkuId_;
		}
		
		public void SetVSkuId(long? value){
			this.vSkuId_ = value;
		}
		public int? GetTotalQuota(){
			return this.totalQuota_;
		}
		
		public void SetTotalQuota(int? value){
			this.totalQuota_ = value;
		}
		public double? GetFav(){
			return this.fav_;
		}
		
		public void SetFav(double? value){
			this.fav_ = value;
		}
		
	}
	
}