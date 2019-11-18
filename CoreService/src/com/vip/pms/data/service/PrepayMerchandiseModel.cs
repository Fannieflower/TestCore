using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PrepayMerchandiseModel {
		
		///<summary>
		/// 商品mid
		///</summary>
		
		private long? merchandiseId_;
		
		///<summary>
		/// 预付商品对应的档期id
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 预付金额类型 1-金额 2-比例
		///</summary>
		
		private short? prepayType_;
		
		///<summary>
		/// 如果prepayType是固定金额，则此处存金额的数值；如果prepayType是比例，则此处存定金比例
		///</summary>
		
		private int? prepayAmount_;
		
		///<summary>
		/// 商品列表页预付提示语模板
		///</summary>
		
		private string listTips_;
		
		///<summary>
		/// 商品详情页预付提示语模板
		///</summary>
		
		private string detailTips_;
		
		public long? GetMerchandiseId(){
			return this.merchandiseId_;
		}
		
		public void SetMerchandiseId(long? value){
			this.merchandiseId_ = value;
		}
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public short? GetPrepayType(){
			return this.prepayType_;
		}
		
		public void SetPrepayType(short? value){
			this.prepayType_ = value;
		}
		public int? GetPrepayAmount(){
			return this.prepayAmount_;
		}
		
		public void SetPrepayAmount(int? value){
			this.prepayAmount_ = value;
		}
		public string GetListTips(){
			return this.listTips_;
		}
		
		public void SetListTips(string value){
			this.listTips_ = value;
		}
		public string GetDetailTips(){
			return this.detailTips_;
		}
		
		public void SetDetailTips(string value){
			this.detailTips_ = value;
		}
		
	}
	
}