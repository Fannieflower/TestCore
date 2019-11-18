using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OldPmsOrderGoodsModel {
		
		///<summary>
		/// 商品尺码ID
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// sizeId
		///</summary>
		
		private string sizeId_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 优惠金额 
		///</summary>
		
		private double? fav_;
		
		///<summary>
		/// 总优惠金额=fav*amount
		///</summary>
		
		private double? total_;
		
		///<summary>
		/// activity&command&special&payment主键
		///</summary>
		
		private string refId_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetSizeId(){
			return this.sizeId_;
		}
		
		public void SetSizeId(string value){
			this.sizeId_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public double? GetFav(){
			return this.fav_;
		}
		
		public void SetFav(double? value){
			this.fav_ = value;
		}
		public double? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(double? value){
			this.total_ = value;
		}
		public string GetRefId(){
			return this.refId_;
		}
		
		public void SetRefId(string value){
			this.refId_ = value;
		}
		
	}
	
}