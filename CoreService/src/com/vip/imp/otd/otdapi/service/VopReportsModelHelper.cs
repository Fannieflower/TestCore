using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.imp.otd.otdapi.service{
	
	
	
	public class VopReportsModelHelper : TBeanSerializer<VopReportsModel>
	{
		
		public static VopReportsModelHelper OBJ = new VopReportsModelHelper();
		
		public static VopReportsModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VopReportsModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vopReports".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.imp.otd.otdapi.service.VopReportModel> value;
						
						value = new List<com.vip.imp.otd.otdapi.service.VopReportModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.imp.otd.otdapi.service.VopReportModel elem0;
								
								elem0 = new com.vip.imp.otd.otdapi.service.VopReportModel();
								com.vip.imp.otd.otdapi.service.VopReportModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetVopReports(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.imp.otd.otdapi.service.VopPageModel value;
						
						value = new com.vip.imp.otd.otdapi.service.VopPageModel();
						com.vip.imp.otd.otdapi.service.VopPageModelHelper.getInstance().Read(value, iprot);
						
						structs.SetPage(value);
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
		
		
		public void Write(VopReportsModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVopReports() != null) {
				
				oprot.WriteFieldBegin("vopReports");
				
				oprot.WriteListBegin();
				foreach(com.vip.imp.otd.otdapi.service.VopReportModel _item0 in structs.GetVopReports()){
					
					
					com.vip.imp.otd.otdapi.service.VopReportModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				
				com.vip.imp.otd.otdapi.service.VopPageModelHelper.getInstance().Write(structs.GetPage(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VopReportsModel bean){
			
			
		}
		
	}
	
}