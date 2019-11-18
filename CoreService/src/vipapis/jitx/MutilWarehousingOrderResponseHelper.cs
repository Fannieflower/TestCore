using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class MutilWarehousingOrderResponseHelper : TBeanSerializer<MutilWarehousingOrderResponse>
	{
		
		public static MutilWarehousingOrderResponseHelper OBJ = new MutilWarehousingOrderResponseHelper();
		
		public static MutilWarehousingOrderResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MutilWarehousingOrderResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("mutil_warehousing_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.MutilWarehousingOrder> value;
						
						value = new List<vipapis.jitx.MutilWarehousingOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.MutilWarehousingOrder elem0;
								
								elem0 = new vipapis.jitx.MutilWarehousingOrder();
								vipapis.jitx.MutilWarehousingOrderHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMutil_warehousing_orders(value);
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
		
		
		public void Write(MutilWarehousingOrderResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMutil_warehousing_orders() != null) {
				
				oprot.WriteFieldBegin("mutil_warehousing_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.MutilWarehousingOrder _item0 in structs.GetMutil_warehousing_orders()){
					
					
					vipapis.jitx.MutilWarehousingOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MutilWarehousingOrderResponse bean){
			
			
		}
		
	}
	
}