using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class ShipResponse {
		
		///<summary>
		/// 成功订单总数
		///</summary>
		
		private int? success_num_;
		
		///<summary>
		/// 成功订单列表
		///</summary>
		
		private List<vipapis.jitx.ShipResult> success_list_;
		
		///<summary>
		/// 失败订单列表
		///</summary>
		
		private List<vipapis.jitx.ShipResult> failed_list_;
		
		///<summary>
		/// 成功订单总数
		///</summary>
		
		private int? failed_num_;
		
		public int? GetSuccess_num(){
			return this.success_num_;
		}
		
		public void SetSuccess_num(int? value){
			this.success_num_ = value;
		}
		public List<vipapis.jitx.ShipResult> GetSuccess_list(){
			return this.success_list_;
		}
		
		public void SetSuccess_list(List<vipapis.jitx.ShipResult> value){
			this.success_list_ = value;
		}
		public List<vipapis.jitx.ShipResult> GetFailed_list(){
			return this.failed_list_;
		}
		
		public void SetFailed_list(List<vipapis.jitx.ShipResult> value){
			this.failed_list_ = value;
		}
		public int? GetFailed_num(){
			return this.failed_num_;
		}
		
		public void SetFailed_num(int? value){
			this.failed_num_ = value;
		}
		
	}
	
}