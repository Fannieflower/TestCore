using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.logistics.carrier.service{
	
	
	public class CarrierLogisticsServiceHelper {
		
		
		
		public class collectShipping_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 揽收列表
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ShippingCollection> collections_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.carrier.service.ShippingCollection> GetCollections(){
				return this.collections_;
			}
			
			public void SetCollections(List<com.vip.vop.logistics.carrier.service.ShippingCollection> value){
				this.collections_ = value;
			}
			
		}
		
		
		
		
		public class forwardShipping_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 转寄运单列表
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ForwardShipping> forward_shippings_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.carrier.service.ForwardShipping> GetForward_shippings(){
				return this.forward_shippings_;
			}
			
			public void SetForward_shippings(List<com.vip.vop.logistics.carrier.service.ForwardShipping> value){
				this.forward_shippings_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class listRefundAddress_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 运单号列表，每次最多10条
			///</summary>
			
			private List<string> logistics_nos_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<string> GetLogistics_nos(){
				return this.logistics_nos_;
			}
			
			public void SetLogistics_nos(List<string> value){
				this.logistics_nos_ = value;
			}
			
		}
		
		
		
		
		public class reportLoadingListDetail_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 装载单请求
			///</summary>
			
			private com.vip.vop.logistics.carrier.service.LoadingListReq loadingListReq_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public com.vip.vop.logistics.carrier.service.LoadingListReq GetLoadingListReq(){
				return this.loadingListReq_;
			}
			
			public void SetLoadingListReq(com.vip.vop.logistics.carrier.service.LoadingListReq value){
				this.loadingListReq_ = value;
			}
			
		}
		
		
		
		
		public class reportPacketInfo_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 包裹信息列表 批量最大100
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.PacketInfo> packetInfos_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.carrier.service.PacketInfo> GetPacketInfos(){
				return this.packetInfos_;
			}
			
			public void SetPacketInfos(List<com.vip.vop.logistics.carrier.service.PacketInfo> value){
				this.packetInfos_ = value;
			}
			
		}
		
		
		
		
		public class reportProblemShipping_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 问题运单列表
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ProblemShipping> problem_shippings_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.carrier.service.ProblemShipping> GetProblem_shippings(){
				return this.problem_shippings_;
			}
			
			public void SetProblem_shippings(List<com.vip.vop.logistics.carrier.service.ProblemShipping> value){
				this.problem_shippings_ = value;
			}
			
		}
		
		
		
		
		public class reportTrace_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 轨迹列表，轨迹列表不能为空，最大支持10单
			///</summary>
			
			private List<com.vip.vop.logistics.ShipmentTraceList> traces_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.ShipmentTraceList> GetTraces(){
				return this.traces_;
			}
			
			public void SetTraces(List<com.vip.vop.logistics.ShipmentTraceList> value){
				this.traces_ = value;
			}
			
		}
		
		
		
		
		public class uploadShippingInterceptResult_args {
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			///<summary>
			/// 运单拦截结果列表 批量最大100
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> intercept_results_;
			
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			public List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> GetIntercept_results(){
				return this.intercept_results_;
			}
			
			public void SetIntercept_results(List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> value){
				this.intercept_results_ = value;
			}
			
		}
		
		
		
		
		public class collectShipping_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> success_;
			
			public List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class forwardShipping_result {
			
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listRefundAddress_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.ShippingAddress> success_;
			
			public List<com.vip.vop.logistics.ShippingAddress> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.ShippingAddress> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class reportLoadingListDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.carrier.service.LoadingListResp success_;
			
			public com.vip.vop.logistics.carrier.service.LoadingListResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.carrier.service.LoadingListResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class reportPacketInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.carrier.service.ReportPacketInfoResp success_;
			
			public com.vip.vop.logistics.carrier.service.ReportPacketInfoResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.carrier.service.ReportPacketInfoResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class reportProblemShipping_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> success_;
			
			public List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class reportTrace_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.logistics.ReportTraceResult> success_;
			
			public List<com.vip.vop.logistics.ReportTraceResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.logistics.ReportTraceResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class uploadShippingInterceptResult_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.logistics.carrier.service.ShippingInterceptResp success_;
			
			public com.vip.vop.logistics.carrier.service.ShippingInterceptResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.logistics.carrier.service.ShippingInterceptResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class collectShipping_argsHelper : TBeanSerializer<collectShipping_args>
		{
			
			public static collectShipping_argsHelper OBJ = new collectShipping_argsHelper();
			
			public static collectShipping_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(collectShipping_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ShippingCollection> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ShippingCollection>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ShippingCollection elem0;
							
							elem0 = new com.vip.vop.logistics.carrier.service.ShippingCollection();
							com.vip.vop.logistics.carrier.service.ShippingCollectionHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetCollections(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(collectShipping_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetCollections() != null) {
					
					oprot.WriteFieldBegin("collections");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ShippingCollection _item0 in structs.GetCollections()){
						
						
						com.vip.vop.logistics.carrier.service.ShippingCollectionHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("collections can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(collectShipping_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class forwardShipping_argsHelper : TBeanSerializer<forwardShipping_args>
		{
			
			public static forwardShipping_argsHelper OBJ = new forwardShipping_argsHelper();
			
			public static forwardShipping_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(forwardShipping_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ForwardShipping> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ForwardShipping>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ForwardShipping elem1;
							
							elem1 = new com.vip.vop.logistics.carrier.service.ForwardShipping();
							com.vip.vop.logistics.carrier.service.ForwardShippingHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetForward_shippings(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(forwardShipping_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetForward_shippings() != null) {
					
					oprot.WriteFieldBegin("forward_shippings");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ForwardShipping _item0 in structs.GetForward_shippings()){
						
						
						com.vip.vop.logistics.carrier.service.ForwardShippingHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("forward_shippings can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(forwardShipping_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listRefundAddress_argsHelper : TBeanSerializer<listRefundAddress_args>
		{
			
			public static listRefundAddress_argsHelper OBJ = new listRefundAddress_argsHelper();
			
			public static listRefundAddress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listRefundAddress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetLogistics_nos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listRefundAddress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetLogistics_nos() != null) {
					
					oprot.WriteFieldBegin("logistics_nos");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetLogistics_nos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("logistics_nos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listRefundAddress_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportLoadingListDetail_argsHelper : TBeanSerializer<reportLoadingListDetail_args>
		{
			
			public static reportLoadingListDetail_argsHelper OBJ = new reportLoadingListDetail_argsHelper();
			
			public static reportLoadingListDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportLoadingListDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.carrier.service.LoadingListReq value;
					
					value = new com.vip.vop.logistics.carrier.service.LoadingListReq();
					com.vip.vop.logistics.carrier.service.LoadingListReqHelper.getInstance().Read(value, iprot);
					
					structs.SetLoadingListReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportLoadingListDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetLoadingListReq() != null) {
					
					oprot.WriteFieldBegin("loadingListReq");
					
					com.vip.vop.logistics.carrier.service.LoadingListReqHelper.getInstance().Write(structs.GetLoadingListReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("loadingListReq can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportLoadingListDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportPacketInfo_argsHelper : TBeanSerializer<reportPacketInfo_args>
		{
			
			public static reportPacketInfo_argsHelper OBJ = new reportPacketInfo_argsHelper();
			
			public static reportPacketInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportPacketInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.PacketInfo> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.PacketInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.PacketInfo elem0;
							
							elem0 = new com.vip.vop.logistics.carrier.service.PacketInfo();
							com.vip.vop.logistics.carrier.service.PacketInfoHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetPacketInfos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportPacketInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetPacketInfos() != null) {
					
					oprot.WriteFieldBegin("packetInfos");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.PacketInfo _item0 in structs.GetPacketInfos()){
						
						
						com.vip.vop.logistics.carrier.service.PacketInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("packetInfos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportPacketInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportProblemShipping_argsHelper : TBeanSerializer<reportProblemShipping_args>
		{
			
			public static reportProblemShipping_argsHelper OBJ = new reportProblemShipping_argsHelper();
			
			public static reportProblemShipping_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportProblemShipping_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ProblemShipping> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ProblemShipping>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ProblemShipping elem1;
							
							elem1 = new com.vip.vop.logistics.carrier.service.ProblemShipping();
							com.vip.vop.logistics.carrier.service.ProblemShippingHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProblem_shippings(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportProblemShipping_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetProblem_shippings() != null) {
					
					oprot.WriteFieldBegin("problem_shippings");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ProblemShipping _item0 in structs.GetProblem_shippings()){
						
						
						com.vip.vop.logistics.carrier.service.ProblemShippingHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("problem_shippings can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportProblemShipping_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportTrace_argsHelper : TBeanSerializer<reportTrace_args>
		{
			
			public static reportTrace_argsHelper OBJ = new reportTrace_argsHelper();
			
			public static reportTrace_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportTrace_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.ShipmentTraceList> value;
					
					value = new List<com.vip.vop.logistics.ShipmentTraceList>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.ShipmentTraceList elem1;
							
							elem1 = new com.vip.vop.logistics.ShipmentTraceList();
							com.vip.vop.logistics.ShipmentTraceListHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetTraces(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportTrace_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetTraces() != null) {
					
					oprot.WriteFieldBegin("traces");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.ShipmentTraceList _item0 in structs.GetTraces()){
						
						
						com.vip.vop.logistics.ShipmentTraceListHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportTrace_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadShippingInterceptResult_argsHelper : TBeanSerializer<uploadShippingInterceptResult_args>
		{
			
			public static uploadShippingInterceptResult_argsHelper OBJ = new uploadShippingInterceptResult_argsHelper();
			
			public static uploadShippingInterceptResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadShippingInterceptResult_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ShippingInterceptResult elem1;
							
							elem1 = new com.vip.vop.logistics.carrier.service.ShippingInterceptResult();
							com.vip.vop.logistics.carrier.service.ShippingInterceptResultHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetIntercept_results(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadShippingInterceptResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				if(structs.GetIntercept_results() != null) {
					
					oprot.WriteFieldBegin("intercept_results");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ShippingInterceptResult _item0 in structs.GetIntercept_results()){
						
						
						com.vip.vop.logistics.carrier.service.ShippingInterceptResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("intercept_results can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadShippingInterceptResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class collectShipping_resultHelper : TBeanSerializer<collectShipping_result>
		{
			
			public static collectShipping_resultHelper OBJ = new collectShipping_resultHelper();
			
			public static collectShipping_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(collectShipping_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ShippingCollectionResult elem1;
							
							elem1 = new com.vip.vop.logistics.carrier.service.ShippingCollectionResult();
							com.vip.vop.logistics.carrier.service.ShippingCollectionResultHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(collectShipping_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ShippingCollectionResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.carrier.service.ShippingCollectionResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(collectShipping_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class forwardShipping_resultHelper : TBeanSerializer<forwardShipping_result>
		{
			
			public static forwardShipping_resultHelper OBJ = new forwardShipping_resultHelper();
			
			public static forwardShipping_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(forwardShipping_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(forwardShipping_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(forwardShipping_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listRefundAddress_resultHelper : TBeanSerializer<listRefundAddress_result>
		{
			
			public static listRefundAddress_resultHelper OBJ = new listRefundAddress_resultHelper();
			
			public static listRefundAddress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listRefundAddress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.ShippingAddress> value;
					
					value = new List<com.vip.vop.logistics.ShippingAddress>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.ShippingAddress elem0;
							
							elem0 = new com.vip.vop.logistics.ShippingAddress();
							com.vip.vop.logistics.ShippingAddressHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listRefundAddress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.ShippingAddress _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.ShippingAddressHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listRefundAddress_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportLoadingListDetail_resultHelper : TBeanSerializer<reportLoadingListDetail_result>
		{
			
			public static reportLoadingListDetail_resultHelper OBJ = new reportLoadingListDetail_resultHelper();
			
			public static reportLoadingListDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportLoadingListDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.carrier.service.LoadingListResp value;
					
					value = new com.vip.vop.logistics.carrier.service.LoadingListResp();
					com.vip.vop.logistics.carrier.service.LoadingListRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportLoadingListDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.carrier.service.LoadingListRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportLoadingListDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportPacketInfo_resultHelper : TBeanSerializer<reportPacketInfo_result>
		{
			
			public static reportPacketInfo_resultHelper OBJ = new reportPacketInfo_resultHelper();
			
			public static reportPacketInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportPacketInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.carrier.service.ReportPacketInfoResp value;
					
					value = new com.vip.vop.logistics.carrier.service.ReportPacketInfoResp();
					com.vip.vop.logistics.carrier.service.ReportPacketInfoRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportPacketInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.carrier.service.ReportPacketInfoRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportPacketInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportProblemShipping_resultHelper : TBeanSerializer<reportProblemShipping_result>
		{
			
			public static reportProblemShipping_resultHelper OBJ = new reportProblemShipping_resultHelper();
			
			public static reportProblemShipping_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportProblemShipping_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> value;
					
					value = new List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.carrier.service.ReportProblemShippingResult elem0;
							
							elem0 = new com.vip.vop.logistics.carrier.service.ReportProblemShippingResult();
							com.vip.vop.logistics.carrier.service.ReportProblemShippingResultHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportProblemShipping_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.carrier.service.ReportProblemShippingResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.carrier.service.ReportProblemShippingResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportProblemShipping_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class reportTrace_resultHelper : TBeanSerializer<reportTrace_result>
		{
			
			public static reportTrace_resultHelper OBJ = new reportTrace_resultHelper();
			
			public static reportTrace_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(reportTrace_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.logistics.ReportTraceResult> value;
					
					value = new List<com.vip.vop.logistics.ReportTraceResult>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.logistics.ReportTraceResult elem1;
							
							elem1 = new com.vip.vop.logistics.ReportTraceResult();
							com.vip.vop.logistics.ReportTraceResultHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(reportTrace_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.logistics.ReportTraceResult _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.logistics.ReportTraceResultHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(reportTrace_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadShippingInterceptResult_resultHelper : TBeanSerializer<uploadShippingInterceptResult_result>
		{
			
			public static uploadShippingInterceptResult_resultHelper OBJ = new uploadShippingInterceptResult_resultHelper();
			
			public static uploadShippingInterceptResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadShippingInterceptResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.logistics.carrier.service.ShippingInterceptResp value;
					
					value = new com.vip.vop.logistics.carrier.service.ShippingInterceptResp();
					com.vip.vop.logistics.carrier.service.ShippingInterceptRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadShippingInterceptResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.logistics.carrier.service.ShippingInterceptRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadShippingInterceptResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class CarrierLogisticsServiceClient : OspRestStub , CarrierLogisticsService  {
			
			
			public CarrierLogisticsServiceClient():base("com.vip.vop.logistics.carrier.service.CarrierLogisticsService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> collectShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ShippingCollection> collections_) {
				
				send_collectShipping(carrier_code_,collections_);
				return recv_collectShipping(); 
				
			}
			
			
			private void send_collectShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ShippingCollection> collections_){
				
				InitInvocation("collectShipping");
				
				collectShipping_args args = new collectShipping_args();
				args.SetCarrier_code(carrier_code_);
				args.SetCollections(collections_);
				
				SendBase(args, collectShipping_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.carrier.service.ShippingCollectionResult> recv_collectShipping(){
				
				collectShipping_result result = new collectShipping_result();
				ReceiveBase(result, collectShipping_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void forwardShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ForwardShipping> forward_shippings_) {
				
				send_forwardShipping(carrier_code_,forward_shippings_);
				recv_forwardShipping();
				
			}
			
			
			private void send_forwardShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ForwardShipping> forward_shippings_){
				
				InitInvocation("forwardShipping");
				
				forwardShipping_args args = new forwardShipping_args();
				args.SetCarrier_code(carrier_code_);
				args.SetForward_shippings(forward_shippings_);
				
				SendBase(args, forwardShipping_argsHelper.getInstance());
			}
			
			
			private void recv_forwardShipping(){
				
				forwardShipping_result result = new forwardShipping_result();
				ReceiveBase(result, forwardShipping_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.logistics.ShippingAddress> listRefundAddress(string carrier_code_,List<string> logistics_nos_) {
				
				send_listRefundAddress(carrier_code_,logistics_nos_);
				return recv_listRefundAddress(); 
				
			}
			
			
			private void send_listRefundAddress(string carrier_code_,List<string> logistics_nos_){
				
				InitInvocation("listRefundAddress");
				
				listRefundAddress_args args = new listRefundAddress_args();
				args.SetCarrier_code(carrier_code_);
				args.SetLogistics_nos(logistics_nos_);
				
				SendBase(args, listRefundAddress_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.ShippingAddress> recv_listRefundAddress(){
				
				listRefundAddress_result result = new listRefundAddress_result();
				ReceiveBase(result, listRefundAddress_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.logistics.carrier.service.LoadingListResp reportLoadingListDetail(string carrier_code_,com.vip.vop.logistics.carrier.service.LoadingListReq loadingListReq_) {
				
				send_reportLoadingListDetail(carrier_code_,loadingListReq_);
				return recv_reportLoadingListDetail(); 
				
			}
			
			
			private void send_reportLoadingListDetail(string carrier_code_,com.vip.vop.logistics.carrier.service.LoadingListReq loadingListReq_){
				
				InitInvocation("reportLoadingListDetail");
				
				reportLoadingListDetail_args args = new reportLoadingListDetail_args();
				args.SetCarrier_code(carrier_code_);
				args.SetLoadingListReq(loadingListReq_);
				
				SendBase(args, reportLoadingListDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.carrier.service.LoadingListResp recv_reportLoadingListDetail(){
				
				reportLoadingListDetail_result result = new reportLoadingListDetail_result();
				ReceiveBase(result, reportLoadingListDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.logistics.carrier.service.ReportPacketInfoResp reportPacketInfo(string carrier_code_,List<com.vip.vop.logistics.carrier.service.PacketInfo> packetInfos_) {
				
				send_reportPacketInfo(carrier_code_,packetInfos_);
				return recv_reportPacketInfo(); 
				
			}
			
			
			private void send_reportPacketInfo(string carrier_code_,List<com.vip.vop.logistics.carrier.service.PacketInfo> packetInfos_){
				
				InitInvocation("reportPacketInfo");
				
				reportPacketInfo_args args = new reportPacketInfo_args();
				args.SetCarrier_code(carrier_code_);
				args.SetPacketInfos(packetInfos_);
				
				SendBase(args, reportPacketInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.carrier.service.ReportPacketInfoResp recv_reportPacketInfo(){
				
				reportPacketInfo_result result = new reportPacketInfo_result();
				ReceiveBase(result, reportPacketInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> reportProblemShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ProblemShipping> problem_shippings_) {
				
				send_reportProblemShipping(carrier_code_,problem_shippings_);
				return recv_reportProblemShipping(); 
				
			}
			
			
			private void send_reportProblemShipping(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ProblemShipping> problem_shippings_){
				
				InitInvocation("reportProblemShipping");
				
				reportProblemShipping_args args = new reportProblemShipping_args();
				args.SetCarrier_code(carrier_code_);
				args.SetProblem_shippings(problem_shippings_);
				
				SendBase(args, reportProblemShipping_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.carrier.service.ReportProblemShippingResult> recv_reportProblemShipping(){
				
				reportProblemShipping_result result = new reportProblemShipping_result();
				ReceiveBase(result, reportProblemShipping_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.logistics.ReportTraceResult> reportTrace(string carrier_code_,List<com.vip.vop.logistics.ShipmentTraceList> traces_) {
				
				send_reportTrace(carrier_code_,traces_);
				return recv_reportTrace(); 
				
			}
			
			
			private void send_reportTrace(string carrier_code_,List<com.vip.vop.logistics.ShipmentTraceList> traces_){
				
				InitInvocation("reportTrace");
				
				reportTrace_args args = new reportTrace_args();
				args.SetCarrier_code(carrier_code_);
				args.SetTraces(traces_);
				
				SendBase(args, reportTrace_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.logistics.ReportTraceResult> recv_reportTrace(){
				
				reportTrace_result result = new reportTrace_result();
				ReceiveBase(result, reportTrace_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.logistics.carrier.service.ShippingInterceptResp uploadShippingInterceptResult(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> intercept_results_) {
				
				send_uploadShippingInterceptResult(carrier_code_,intercept_results_);
				return recv_uploadShippingInterceptResult(); 
				
			}
			
			
			private void send_uploadShippingInterceptResult(string carrier_code_,List<com.vip.vop.logistics.carrier.service.ShippingInterceptResult> intercept_results_){
				
				InitInvocation("uploadShippingInterceptResult");
				
				uploadShippingInterceptResult_args args = new uploadShippingInterceptResult_args();
				args.SetCarrier_code(carrier_code_);
				args.SetIntercept_results(intercept_results_);
				
				SendBase(args, uploadShippingInterceptResult_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.logistics.carrier.service.ShippingInterceptResp recv_uploadShippingInterceptResult(){
				
				uploadShippingInterceptResult_result result = new uploadShippingInterceptResult_result();
				ReceiveBase(result, uploadShippingInterceptResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}