using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class VendorBearInfo {
		
		///<summary>
		/// 比例
		///</summary>
		
		private string scaleValue_;
		
		///<summary>
		/// 券数量
		///</summary>
		
		private int? rollNum_;
		
		///<summary>
		/// 额外返利
		///</summary>
		
		private string extraValue_;
		
		///<summary>
		/// 承担方式,0:未知,1：账扣,2:电汇
		///</summary>
		
		private byte? bearType_;
		
		///<summary>
		/// 承担金额
		///</summary>
		
		private string bearValue_;
		
		///<summary>
		/// 原扣点
		///</summary>
		
		private string oldDeduction_;
		
		///<summary>
		/// 新扣点
		///</summary>
		
		private string newDeduction_;
		
		///<summary>
		/// 直发比例
		///</summary>
		
		private string oxoScaleValue_;
		
		public string GetScaleValue(){
			return this.scaleValue_;
		}
		
		public void SetScaleValue(string value){
			this.scaleValue_ = value;
		}
		public int? GetRollNum(){
			return this.rollNum_;
		}
		
		public void SetRollNum(int? value){
			this.rollNum_ = value;
		}
		public string GetExtraValue(){
			return this.extraValue_;
		}
		
		public void SetExtraValue(string value){
			this.extraValue_ = value;
		}
		public byte? GetBearType(){
			return this.bearType_;
		}
		
		public void SetBearType(byte? value){
			this.bearType_ = value;
		}
		public string GetBearValue(){
			return this.bearValue_;
		}
		
		public void SetBearValue(string value){
			this.bearValue_ = value;
		}
		public string GetOldDeduction(){
			return this.oldDeduction_;
		}
		
		public void SetOldDeduction(string value){
			this.oldDeduction_ = value;
		}
		public string GetNewDeduction(){
			return this.newDeduction_;
		}
		
		public void SetNewDeduction(string value){
			this.newDeduction_ = value;
		}
		public string GetOxoScaleValue(){
			return this.oxoScaleValue_;
		}
		
		public void SetOxoScaleValue(string value){
			this.oxoScaleValue_ = value;
		}
		
	}
	
}