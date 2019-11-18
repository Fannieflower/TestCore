using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActGiftInfoModel {
		
		///<summary>
		/// 由type定义其值含义
		///</summary>
		
		private int? giftId_;
		
		///<summary>
		/// 折扣/金额/赠送数量
		///</summary>
		
		private int? giftNum_;
		
		///<summary>
		/// 赠品名称
		///</summary>
		
		private string giftName_;
		
		///<summary>
		/// 满足条件
		///</summary>
		
		private int? buyValue_;
		
		///<summary>
		/// B2C赠品更多信息
		///</summary>
		
		private string giftDetail_;
		
		///<summary>
		/// 价格
		///</summary>
		
		private double? price_;
		
		///<summary>
		/// 由type定义其值含义
		///</summary>
		
		private long? merItemNo_;
		
		public int? GetGiftId(){
			return this.giftId_;
		}
		
		public void SetGiftId(int? value){
			this.giftId_ = value;
		}
		public int? GetGiftNum(){
			return this.giftNum_;
		}
		
		public void SetGiftNum(int? value){
			this.giftNum_ = value;
		}
		public string GetGiftName(){
			return this.giftName_;
		}
		
		public void SetGiftName(string value){
			this.giftName_ = value;
		}
		public int? GetBuyValue(){
			return this.buyValue_;
		}
		
		public void SetBuyValue(int? value){
			this.buyValue_ = value;
		}
		public string GetGiftDetail(){
			return this.giftDetail_;
		}
		
		public void SetGiftDetail(string value){
			this.giftDetail_ = value;
		}
		public double? GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(double? value){
			this.price_ = value;
		}
		public long? GetMerItemNo(){
			return this.merItemNo_;
		}
		
		public void SetMerItemNo(long? value){
			this.merItemNo_ = value;
		}
		
	}
	
}