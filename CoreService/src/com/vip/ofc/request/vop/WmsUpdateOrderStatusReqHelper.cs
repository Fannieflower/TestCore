using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.ofc.request.vop{
	
	
	
	public class WmsUpdateOrderStatusReqHelper : TBeanSerializer<WmsUpdateOrderStatusReq>
	{
		
		public static WmsUpdateOrderStatusReqHelper OBJ = new WmsUpdateOrderStatusReqHelper();
		
		public static WmsUpdateOrderStatusReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WmsUpdateOrderStatusReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("wmsOrderStatusList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.ofc.request.vop.WmsOrderStatusVO> value;
						
						value = new List<com.vip.ofc.request.vop.WmsOrderStatusVO>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.ofc.request.vop.WmsOrderStatusVO elem0;
								
								elem0 = new com.vip.ofc.request.vop.WmsOrderStatusVO();
								com.vip.ofc.request.vop.WmsOrderStatusVOHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWmsOrderStatusList(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
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
		
		
		public void Write(WmsUpdateOrderStatusReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWmsOrderStatusList() != null) {
				
				oprot.WriteFieldBegin("wmsOrderStatusList");
				
				oprot.WriteListBegin();
				foreach(com.vip.ofc.request.vop.WmsOrderStatusVO _item0 in structs.GetWmsOrderStatusList()){
					
					
					com.vip.ofc.request.vop.WmsOrderStatusVOHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WmsUpdateOrderStatusReq bean){
			
			
		}
		
	}
	
}