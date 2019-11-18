using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class AfterSaleDetailInfo {
		
		///<summary>
		/// 商品佣金售后变动:仅在订单完结之后发生售后时返回，无售后时为空
		///</summary>
		
		private string afterSaleChangedCommission_;
		
		///<summary>
		/// 商品数量售后变动:仅在订单完结之后发生售后时返回，无售后时为空
		///</summary>
		
		private int? afterSaleChangedGoodsCount_;
		
		///<summary>
		/// 商品售后单号，无售后时为空
		///</summary>
		
		private string afterSaleSn_;
		
		///<summary>
		/// 商品售后状态：1-售后中，2-售后完成，3-售后取消，无售后时为空
		///</summary>
		
		private int? afterSaleStatus_;
		
		///<summary>
		/// 售后类型：1-退货，2-换货,无售后时为空
		///</summary>
		
		private int? afterSaleType_;
		
		///<summary>
		/// 售后完成时间，时间戳，单位：毫秒，无售后时为空
		///</summary>
		
		private long? afterSaleFinishTime_;
		
		public string GetAfterSaleChangedCommission(){
			return this.afterSaleChangedCommission_;
		}
		
		public void SetAfterSaleChangedCommission(string value){
			this.afterSaleChangedCommission_ = value;
		}
		public int? GetAfterSaleChangedGoodsCount(){
			return this.afterSaleChangedGoodsCount_;
		}
		
		public void SetAfterSaleChangedGoodsCount(int? value){
			this.afterSaleChangedGoodsCount_ = value;
		}
		public string GetAfterSaleSn(){
			return this.afterSaleSn_;
		}
		
		public void SetAfterSaleSn(string value){
			this.afterSaleSn_ = value;
		}
		public int? GetAfterSaleStatus(){
			return this.afterSaleStatus_;
		}
		
		public void SetAfterSaleStatus(int? value){
			this.afterSaleStatus_ = value;
		}
		public int? GetAfterSaleType(){
			return this.afterSaleType_;
		}
		
		public void SetAfterSaleType(int? value){
			this.afterSaleType_ = value;
		}
		public long? GetAfterSaleFinishTime(){
			return this.afterSaleFinishTime_;
		}
		
		public void SetAfterSaleFinishTime(long? value){
			this.afterSaleFinishTime_ = value;
		}
		
	}
	
}