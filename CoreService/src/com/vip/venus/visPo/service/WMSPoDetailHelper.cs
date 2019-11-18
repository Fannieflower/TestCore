using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class WMSPoDetailHelper : TBeanSerializer<WMSPoDetail>
	{
		
		public static WMSPoDetailHelper OBJ = new WMSPoDetailHelper();
		
		public static WMSPoDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WMSPoDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("poNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoNo(value);
					}
					
					
					
					
					
					if ("poHeader".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.venus.visPo.service.WmsPoHeaderNew value;
						
						value = new com.vip.venus.visPo.service.WmsPoHeaderNew();
						com.vip.venus.visPo.service.WmsPoHeaderNewHelper.getInstance().Read(value, iprot);
						
						structs.SetPoHeader(value);
					}
					
					
					
					
					
					if ("poDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.venus.visPo.service.WmsPoDetailNew> value;
						
						value = new List<com.vip.venus.visPo.service.WmsPoDetailNew>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.venus.visPo.service.WmsPoDetailNew elem2;
								
								elem2 = new com.vip.venus.visPo.service.WmsPoDetailNew();
								com.vip.venus.visPo.service.WmsPoDetailNewHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPoDetails(value);
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
		
		
		public void Write(WMSPoDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPoNo() != null) {
				
				oprot.WriteFieldBegin("poNo");
				oprot.WriteString(structs.GetPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoHeader() != null) {
				
				oprot.WriteFieldBegin("poHeader");
				
				com.vip.venus.visPo.service.WmsPoHeaderNewHelper.getInstance().Write(structs.GetPoHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoDetails() != null) {
				
				oprot.WriteFieldBegin("poDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.venus.visPo.service.WmsPoDetailNew _item0 in structs.GetPoDetails()){
					
					
					com.vip.venus.visPo.service.WmsPoDetailNewHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WMSPoDetail bean){
			
			
		}
		
	}
	
}