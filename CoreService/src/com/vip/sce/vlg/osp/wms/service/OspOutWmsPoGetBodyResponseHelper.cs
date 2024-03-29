using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	public class OspOutWmsPoGetBodyResponseHelper : TBeanSerializer<OspOutWmsPoGetBodyResponse>
	{
		
		public static OspOutWmsPoGetBodyResponseHelper OBJ = new OspOutWmsPoGetBodyResponseHelper();
		
		public static OspOutWmsPoGetBodyResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OspOutWmsPoGetBodyResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("returnList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModel> value;
						
						value = new List<com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModel elem1;
								
								elem1 = new com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModel();
								com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReturnList(value);
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
		
		
		public void Write(OspOutWmsPoGetBodyResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturnList() != null) {
				
				oprot.WriteFieldBegin("returnList");
				
				oprot.WriteListBegin();
				foreach(com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModel _item0 in structs.GetReturnList()){
					
					
					com.vip.sce.vlg.osp.wms.service.OspOutWmsPoBatchFModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OspOutWmsPoGetBodyResponse bean){
			
			
		}
		
	}
	
}