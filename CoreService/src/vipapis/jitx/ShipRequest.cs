using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class ShipRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 发货列表
		///</summary>
		
		private List<vipapis.jitx.Ship> ships_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<vipapis.jitx.Ship> GetShips(){
			return this.ships_;
		}
		
		public void SetShips(List<vipapis.jitx.Ship> value){
			this.ships_ = value;
		}
		
	}
	
}