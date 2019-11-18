using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class WayBillResponseHelper : TBeanSerializer<WayBillResponse>
	{
		
		public static WayBillResponseHelper OBJ = new WayBillResponseHelper();
		
		public static WayBillResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WayBillResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.vcloud.common.api.Pagination value;
						
						value = new com.vip.vop.vcloud.common.api.Pagination();
						com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
					}
					
					
					
					
					
					if ("wayBills".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.order.WayBill> value;
						
						value = new List<com.vip.vop.vcloud.order.WayBill>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.order.WayBill elem1;
								
								elem1 = new com.vip.vop.vcloud.order.WayBill();
								com.vip.vop.vcloud.order.WayBillHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWayBills(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(WayBillResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWayBills() != null) {
				
				oprot.WriteFieldBegin("wayBills");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.order.WayBill _item0 in structs.GetWayBills()){
					
					
					com.vip.vop.vcloud.order.WayBillHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WayBillResponse bean){
			
			
		}
		
	}
	
}