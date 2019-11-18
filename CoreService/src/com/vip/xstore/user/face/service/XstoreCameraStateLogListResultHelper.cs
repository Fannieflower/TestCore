using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraStateLogListResultHelper : TBeanSerializer<XstoreCameraStateLogListResult>
	{
		
		public static XstoreCameraStateLogListResultHelper OBJ = new XstoreCameraStateLogListResultHelper();
		
		public static XstoreCameraStateLogListResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraStateLogListResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("xstoreBoxStateLogs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.user.face.service.XstoreBoxStateLogModel> value;
						
						value = new List<com.vip.xstore.user.face.service.XstoreBoxStateLogModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.user.face.service.XstoreBoxStateLogModel elem0;
								
								elem0 = new com.vip.xstore.user.face.service.XstoreBoxStateLogModel();
								com.vip.xstore.user.face.service.XstoreBoxStateLogModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetXstoreBoxStateLogs(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("pageInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.common.PageInfo value;
						
						value = new com.vip.xstore.user.face.service.common.PageInfo();
						com.vip.xstore.user.face.service.common.PageInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetPageInfo(value);
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
		
		
		public void Write(XstoreCameraStateLogListResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetXstoreBoxStateLogs() != null) {
				
				oprot.WriteFieldBegin("xstoreBoxStateLogs");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.user.face.service.XstoreBoxStateLogModel _item0 in structs.GetXstoreBoxStateLogs()){
					
					
					com.vip.xstore.user.face.service.XstoreBoxStateLogModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageInfo() != null) {
				
				oprot.WriteFieldBegin("pageInfo");
				
				com.vip.xstore.user.face.service.common.PageInfoHelper.getInstance().Write(structs.GetPageInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraStateLogListResult bean){
			
			
		}
		
	}
	
}