using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class XStoreAddressPageRes {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 地址信息列表
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> addresses_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> GetAddresses(){
			return this.addresses_;
		}
		
		public void SetAddresses(List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value){
			this.addresses_ = value;
		}
		
	}
	
}