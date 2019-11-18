using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActFavModel {
		
		///<summary>
		/// 计算源起始数量。此值包含在本段计算范围内，即source_amount_start&le; amount 为有效。
		///</summary>
		
		private double? buy_;
		
		///<summary>
		/// 计算目标数量。source_amount_start&le; amount &lt;source_amount_end时，按target_amount的值进行计算。注意区间是左闭右开。
		///</summary>
		
		private double? cut_;
		
		///<summary>
		/// 档次列表
		///</summary>
		
		private List<com.vip.pms.data.service.PmsActGiftInfoModel> pmsActGiftInfoList_;
		
		///<summary>
		/// 买赠活动阶梯状态
		///</summary>
		
		private byte? stepStatus_;
		
		public double? GetBuy(){
			return this.buy_;
		}
		
		public void SetBuy(double? value){
			this.buy_ = value;
		}
		public double? GetCut(){
			return this.cut_;
		}
		
		public void SetCut(double? value){
			this.cut_ = value;
		}
		public List<com.vip.pms.data.service.PmsActGiftInfoModel> GetPmsActGiftInfoList(){
			return this.pmsActGiftInfoList_;
		}
		
		public void SetPmsActGiftInfoList(List<com.vip.pms.data.service.PmsActGiftInfoModel> value){
			this.pmsActGiftInfoList_ = value;
		}
		public byte? GetStepStatus(){
			return this.stepStatus_;
		}
		
		public void SetStepStatus(byte? value){
			this.stepStatus_ = value;
		}
		
	}
	
}